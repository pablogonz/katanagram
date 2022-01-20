using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsCali
{
    public partial class RegistrodeProfesores : Form
    {
        Random random = new Random();

        public RegistrodeProfesores()
        {
            InitializeComponent();
        }

        private bool Verificar()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(control.Text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void RegistrarP_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "INSERT INTO profesor(ID_Profesor, Nombres_Profesor,Apellidos_Profesor, Password, Asignatura_Imparte) VALUES(@ID_Profesor, @Nombres_Profesor, @Apellidos_Profesor, @Password, @Asignatura_Imparte)";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            if (ValidarControles())
            {
                if (!Existe2())
                {
                    comando.Parameters.Clear();
                    comando.Parameters.Add(new SQLiteParameter("@ID_Profesor", BoxIDP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Nombres_Profesor", BoxNameP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Apellidos_Profesor", BoxLastNP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Password", BoxNameP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Asignatura_Imparte", cboAsignaturas.Text));

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        sql.Close();
                        Registrar_Asignatura();
                        MessageBox.Show("El profesor fue creado exitosamente!");
                        Limpiar_Campos();
                    }
                    else MessageBox.Show("Se ha generado un error y no pudo crearse el registro. Favor verficar.");
                }
                else MessageBox.Show("Ya existe un profesor registrado con ese ID. Favor verificar!");
            }
            else MessageBox.Show("Existen campos en blanco. Favor verificar!.");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "Delete From Profesor Where ID_Profesor=@ID_Profesor";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

                if (Existe2())
                {
                    if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        comando.Parameters.Clear();
                        comando.Parameters.Add(new SQLiteParameter("@ID_Profesor", BoxIDP.Text));

                        if (comando.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("El registro del profesor fue BORRADO exitosamente!");
                            Limpiar_Campos();
                            Habilitar_Botones(true);
                        }
                        else MessageBox.Show("Se produjo un error al intentar borrar el registro. Favor verficar!."); 
                    }
                }
                else MessageBox.Show("No existe ningún profesor asociado a este ID. Favor verificar!");

            sql.Close();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "Update Profesor Set Nombres_Profesor=@Nombres_Profesor, Apellidos_Profesor=@Apellidos_Profesor, Asignatura_Imparte=@Asignatura Where ID_Profesor=@ID_Profesor";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            if (ValidarControles())
            {
                if (Existe2())
                {
                    comando.Parameters.Clear();
                    comando.Parameters.Add(new SQLiteParameter("@ID_Profesor", BoxIDP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Nombres_Profesor", BoxNameP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Apellidos_Profesor", BoxLastNP.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Asignatura", cboAsignaturas.Text));

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        sql.Close();
                        Registrar_Asignatura();
                        MessageBox.Show("Los datos del profesor fueron ACTUALIZADOS exitosamente!");
                        Limpiar_Campos();
                        Habilitar_Botones(true);
                    }
                    else MessageBox.Show("Se ha generado un error y no pudo crearse el registro. Favor verficar.");
                }
                else {  
                    MessageBox.Show("No existen datos de profesores asociados a este ID. Favor verificar!");
                    Limpiar_Campos();
                    Habilitar_Botones(true);
                }
            }
            else MessageBox.Show("Existen campos en blanco. Favor verificar!.");
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            BoxIDP.Text = textBox1.Text;
            switch (Existe2())
            {
                case true: 
                    Buscar(); 
                    break;

                case false: 
                    MessageBox.Show("El ID no existe. Favor verificar!!");
                    Limpiar_Campos();
                    Habilitar_Botones(true);
                    break;
            }
        }

        private void Limpiar_Campos()
        {
            BoxIDP.Text = "";
            BoxNameP.Text = "";
            BoxLastNP.Text = "";
            boxPassword.Text = "";
            textBox1.Text = "";
            cboAsignaturas.SelectedIndex = -1;
        }

        private Boolean ValidarControles()
        {
            if (BoxIDP.TextLength > 0 && BoxNameP.TextLength > 0 && BoxLastNP.TextLength > 0 && boxPassword.TextLength > 0 && cboAsignaturas.SelectedIndex > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Existe2()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            // ORIGINAL: string consulta = "select * from profesor where ID_Profesor=@ID_Profesor";
            string consulta = "Select ID, Password, Tipo_Usuario from vwBuscar_Usuarios Where ID=@ID_Profesor";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID_Profesor", BoxIDP.Text));

            SQLiteDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (BoxIDP.Text == reader.GetValue(reader.GetOrdinal("ID")).ToString())
                {
                    reader.Close();
                    sql.Close();
                    Habilitar_Botones(false);
                    RegistrarP.Enabled = true;
                    return true;                    
                }
                else
                {
                    reader.Close();
                    sql.Close();
                    Habilitar_Botones(true);
                    return false;

                }

            }
            else return false;
        }

        private void Buscar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from profesor where ID_Profesor = '{textBox1.Text}'";
            //string consulta = "Select ID, Password, Tipo_Usuario from vwBuscar_Usuarios where ID=@ID";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);
            //cmd.Parameters.Clear();
            //cmd.Parameters.Add(new SQLiteParameter("@ID", textBox1.Text));

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                BoxNameP.Text = reader.GetValue(reader.GetOrdinal("Nombres_Profesor")).ToString();
                BoxLastNP.Text = reader.GetValue(reader.GetOrdinal("Apellidos_Profesor")).ToString();
                // ORIGINAL: boxPassword.Text = reader.GetValue(reader.GetOrdinal("Password")).ToString();
                boxPassword.Text = "**********";
                cboAsignaturas.Text = reader.GetValue(reader.GetOrdinal("Asignatura_Imparte")).ToString();
                Habilitar_Botones(false);
                RegistrarP.Enabled = true;
                textBox1.ResetText();
            }
            else {
                MessageBox.Show("El ID digitado no existe. Favor verificar.");
                textBox1.ResetText();
            }

            reader.Close();
            sql.Close();
        }

        private void Habilitar_Botones(Boolean Habilitar = true)
        {
            RegistrarP.Enabled = Habilitar;                  //Botón Registrar
            bEliminar.Enabled = !Habilitar;
            bActualizar.Enabled = !Habilitar;

        }

        private void Generate_ID()
        {
            Random random = new Random();
            int number = random.Next(1, 9999999);

            while (Comprobar_ID(number))
            {
                number = random.Next(1, 9999999);
            }

            BoxIDP.Text = number.ToString();
        }

        private bool Comprobar_ID(int id)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from profesor where ID_Profesor='{id}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (BoxIDP.Text == reader.GetValue(reader.GetOrdinal("ID_Profesor")).ToString())
                {
                    reader.Close();
                    sql.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    sql.Close();
                    return false;
                }

            }
            else return false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Generate_ID();
        }

        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private string RandomString(int tamaño, bool lower = false)
        {
            var builder = new StringBuilder(tamaño);
            char offset = lower ? 'a' : 'A';
            int letters = 26;

            for (var i = 0; i < tamaño; i++)
            {
                var @char = (char)random.Next(offset, offset + letters);
                builder.Append(@char);
            }

            return lower ? builder.ToString().ToLower() : builder.ToString();
        }

        private string Generate_Password()
        {
            var passwordBuild = new StringBuilder();
            passwordBuild.Append(RandomString(4, true));

            passwordBuild.Append(RandomNumber(1000, 9999));

            passwordBuild.Append(RandomString(2));
            return passwordBuild.ToString();
        }

        private void buttonGenerarPassword_Click(object sender, EventArgs e)
        {
            boxPassword.Text = Generate_Password();
        }

        private void Llenar_ComboBoxAsignaturas()
        {
            SQLiteConnection miConexion = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            miConexion.Open();
            SQLiteCommand comando = new SQLiteCommand("Select Nombre_Asignatura from asignatura order by Nombre_Asignatura", miConexion);
            SQLiteDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cboAsignaturas.Items.Add(reader.GetValue(reader.GetOrdinal("Nombre_Asignatura")).ToString());
            }

            reader.Close();
            miConexion.Close();
        }

        private void RegistrodeProfesores_Load(object sender, EventArgs e)
        {
            Llenar_ComboBoxAsignaturas();
            Habilitar_Botones(true);
        }

        private void Registrar_Asignatura()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            //string consulta = $"Update asignatura Set Profesor_Asignado='{BoxIDP.Text}' Where Clave='{cboAsignaturas.Text}'";
            string nombre_unificado_prof = BoxNameP.Text + ' ' + BoxLastNP.Text;
            // original: string consulta = $"Update asignatura Set Profesor_Asignado='{BoxIDP.Text}' Where Nombre_Asignatura='{cboAsignaturas.Text}'";
            string consulta = $"Update asignatura Set Profesor_Asignado='{nombre_unificado_prof}' Where Nombre_Asignatura='{cboAsignaturas.Text}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.ExecuteNonQuery();

            sql.Close();
        }
    }
}
