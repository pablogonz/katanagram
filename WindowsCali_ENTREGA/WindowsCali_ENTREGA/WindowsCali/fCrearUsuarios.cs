using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCali
{
    public partial class fCrearUsuarios : Form
    {
        Random random = new Random();

        public fCrearUsuarios()
        {
            InitializeComponent();
        }

        public bool Usuario_Existe()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            string consulta = "select * from user where User=@Usuario";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@Usuario", txtID_Usuario.Text));

            if (comando.ExecuteNonQuery() == 1)
            {
                sql.Close();
                return true;
            }
            else
            {
                sql.Close();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Existen_Campos_Vacios())
            {
                MessageBox.Show("Existen campos en blanco. Favor verificar.");
            }
            else
            {
                if (Usuario_Existe())
                {
                    MessageBox.Show("El usuario ya existe. Debe seleccionar uno nuevo");
                }
                else
                {
                    Grabar_Datos();
                }
            }
        }

        private void Grabar_Datos()
        {
            SQLiteConnection cnnCrear = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            cnnCrear.Open();
            SQLiteCommand miCmd = new SQLiteCommand("Insert into User (User, vPass, Tipo_Usuario, Nombres, Apellidos) values (@User, @vPass, @Tipo_Usuario, @Nombres, @Apellidos)", cnnCrear);
            miCmd.Parameters.Clear();
            miCmd.Parameters.Add(new SQLiteParameter("@User", txtID_Usuario.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@vPass", txtClave.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Tipo_Usuario", cboTipo_Usuario.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Nombres", txtNombres.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Apellidos", txtApellidos.Text));


            if (miCmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("El usuario fue registrado exitosamente!.");
                Limpiar_Campos();
                Habilitar_Controles(true);
            }
            else
            {
                MessageBox.Show("Se ha producido un error tratando de crear el registro!. Favor verificar.");
                Habilitar_Controles(true);
            }

        }

        private void Actualizar_Datos()
        {
            SQLiteConnection cnnCrear = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            cnnCrear.Open();
            SQLiteCommand miCmd = new SQLiteCommand("Update User Set User=@User, vPass=@vPass, Tipo_Usuario=@Tipo_Usuario, Nombres=@Nombres, Apellidos=@Apellidos Where User=@User", cnnCrear);
            miCmd.Parameters.Clear();
            miCmd.Parameters.Add(new SQLiteParameter("@User", txtID_Usuario.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@vPass", txtClave.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Tipo_Usuario", cboTipo_Usuario.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Nombres", txtNombres.Text));
            miCmd.Parameters.Add(new SQLiteParameter("@Apellidos", txtApellidos.Text));


            if (miCmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("El usuario fue actualizado exitosamente!.");
                Limpiar_Campos();
                Habilitar_Controles(true);
            }
            else
            {
                MessageBox.Show("Se ha producido un error tratando de crear el registro!. Favor verificar.");
                Habilitar_Controles(false);
            }

        }
        private void Limpiar_Campos()
        {
            txtNombres.ResetText();
            txtApellidos.ResetText();
            txtID_Usuario.ResetText();
            txtClave.ResetText();
            cboTipo_Usuario.SelectedIndex = -1;
        }

        private void Habilitar_Controles(Boolean Valor = true)
        {
            btnGrabar.Enabled = Valor;
            btnActualizar.Enabled = !Valor;
            btnEliminar.Enabled = !Valor;
        }

        private Boolean Existen_Campos_Vacios()
        {
            int Contador = 0;

            foreach (Control txtControl in groupBox1.Controls)
            {
                if (txtControl.GetType().ToString() == "System.Windows.Forms.TextBox" && txtControl.Text.Length == 0)
                {
                    Contador++;
                }
            }

            if (Contador > 0)
            {
                return true;
            }
            else return false;
        }

        private void fCrearUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboTipo_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Generate_ID()
        {
            Random random = new Random();
            int number = random.Next(1, 9999999);

            while (Comprobar_ID(number))
            {
                number = random.Next(1, 9999999);
            }

            txtID_Usuario.Text = number.ToString();
        }

        private bool Comprobar_ID(int id)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from estudiante where ID='{id}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (txtID_Usuario.Text == reader.GetValue(reader.GetOrdinal("ID")).ToString())
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
            else
            {
                reader.Close();
                sql.Close();
                return false;
            }
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

        int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private string Generate_Password()
        {
            var passwordBuild = new StringBuilder();
            passwordBuild.Append(RandomString(4, true));

            passwordBuild.Append(RandomNumber(1000, 9999));

            passwordBuild.Append(RandomString(2));
            return passwordBuild.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Generate_ID();
        }

        private void btnGenerarClave_Click(object sender, EventArgs e)
        {
            txtClave.Text = Generate_Password();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Existen_Campos_Vacios())
            {
                MessageBox.Show("Existen campos en blanco. Favor verificar.");
            }
            else
            {
                if (Usuario_Existe())
                {
                    MessageBox.Show("El usuario ya existe. Debe seleccionar uno nuevo");
                }
                else
                {
                    Actualizar_Datos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            string consulta = "select User, vPass, Tipo_Usuario, Nombres, Apellidos from user where User=@Usuario";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@Usuario", txtID_Buscar.Text));

            SQLiteDataReader miLector = comando.ExecuteReader();

            if (miLector.Read())
            {
                txtID_Usuario.Text = miLector[0].ToString();
                txtClave.Text = miLector[1].ToString();
                cboTipo_Usuario.Text = miLector[2].ToString();
                txtNombres.Text = miLector[3].ToString();
                txtApellidos.Text = miLector[4].ToString();

                Habilitar_Controles(false);
                btnGrabar.Enabled = true;
                txtID_Buscar.ResetText();
            }
            else
            {
                MessageBox.Show("ID de usuario no existe. Favor verificar.");
            }

            miLector.Close();
            sql.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
                sql.Open();

                string consulta = $"Delete From User Where User='{txtID_Usuario.Text}'";
                SQLiteCommand cmdBorrar = new SQLiteCommand(consulta, sql);

                if (cmdBorrar.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("El registro fue borrado satisfactoriamente.");
                    Limpiar_Campos();
                    Habilitar_Controles(true);
                    sql.Close();
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser borrado. Favor verificar.");

                }
            }
            else
            {
                Limpiar_Campos();
                Habilitar_Controles(true);
            }
        }
    }
}
