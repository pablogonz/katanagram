using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
//using System.Data.SqlClient;
using System.Data.Entity.Migrations.Sql;

namespace WindowsCali
{
    public partial class RegistrodeEstudiantes : Form
    {
        string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\DataBaseWindowsCali";
        string ID_Original;
        Random random = new Random();

        public RegistrodeEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón Registrar

            if (ValidarControles())
            {
                if (!Existe2())
                {
                    Registrar();
                }
                else
                {
                    MessageBox.Show("Ya existe un estudiante registrado con ese ID. Favor verificar!");                  
                }
            } else MessageBox.Show("Existen campos en blanco. Favor verificar!.");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            // Original: switch (ValidarControles())

            switch (ValidarControles() || 1==1)
            {
                case true:
                    
                if (Existe2())
                {
                    if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        EliminarEstudiante();
                        MessageBox.Show("El registro del estudiante fue BORRADO exitosamente!");
                        Limpiar_Campos();
                        Habilitar_Botones(true);
                    }
                }
                else MessageBox.Show("No existe ningún estudiante con ese ID. Favor verificar!"); break;

                case false: MessageBox.Show("Existen campos en blanco. Favor verificar!."); break;
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "SELECT ID, Nombres, Apellidos, ID_Carrera, Password From Estudiante Where ID=@ID";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", textBox1.Text));

            SQLiteDataReader miLector = comando.ExecuteReader();

            if (miLector.Read())
            {
                BoxIDE.Text = miLector[0].ToString();
                BoxNameE.Text = miLector[1].ToString();
                BoxLastNE.Text = miLector[2].ToString();
                CBOCARRERA.Text = miLector[3].ToString();
                // Original :         boxPasswordE.Text = miLector[4].ToString();
                boxPasswordE.Text="";
                ID_Original = BoxIDE.Text;
                Habilitar_Botones(false);
                button1.Enabled = true;
            }
            else {  
                MessageBox.Show("No existe estudiante registrado con el ID digitado.");
                Limpiar_Campos();
                textBox1.ResetText();
                ID_Original ="";
                Habilitar_Botones(true);
            }

            miLector.Close();
            sql.Close();
        }

        private void Habilitar_Botones(Boolean Habilitar=true)
        {
            button1.Enabled =Habilitar;                  //Botón Registrar
            bEliminar.Enabled =!Habilitar;
            bActualizar.Enabled =!Habilitar;
                
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            switch (ValidarControles())
            {
                case true:

                    if (Existe2())
                    {
                        Actualizar();
                        MessageBox.Show("El estudiante fue ACTUALIZADO exitosamente!");
                        Limpiar_Campos();
                        Habilitar_Botones(true);
                    }
                    else MessageBox.Show("No existe estudiante asociado a ese ID. Favor verificar!");

                    break;

                case false: MessageBox.Show("Existen campos en blanco. Favor verificar!."); break;
            }
        }

        private void Limpiar_Campos()
        {
            BoxIDE.Text = "";
            BoxNameE.Text = "";
            BoxLastNE.Text = "";
            //CBOCARRERA.Text =  //Comentado porque no quitaba el texto de ComboBox
            CBOCARRERA.SelectedIndex = -1;
            boxPasswordE.Text = "";
            textBox1.Text = "";
        }

        private Boolean ValidarControles()
        {
            if (BoxIDE.TextLength > 0 && BoxNameE.TextLength > 0 && BoxLastNE.TextLength > 0 && CBOCARRERA.Text.Length > 0)
            {
                return true;
            } else return false;   
        }

        private void Registrar()
        {
            SQLiteConnection cnnRegistrar = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            cnnRegistrar.Open();

            string consulta = $"INSERT INTO estudiante(ID, Nombres,Apellidos,ID_Carrera,Password) VALUES('{BoxIDE.Text}','{BoxNameE.Text}','{BoxLastNE.Text}','{CBOCARRERA.Text}','{boxPasswordE.Text}')";
            SQLiteCommand cmdRegistrar = new SQLiteCommand(consulta, cnnRegistrar);

            //cmdRegistrar.Parameters.Clear();
            //cmdRegistrar.Parameters.Add(new SQLiteParameter("@ID", BoxIDE.Text));
            //cmdRegistrar.Parameters.Add(new SQLiteParameter("@Nombres", BoxNameE.Text));
            //cmdRegistrar.Parameters.Add(new SQLiteParameter("@Apellidos", BoxLastNE.Text));
            //cmdRegistrar.Parameters.Add(new SQLiteParameter("@ID_Carrera", CBOCARRERA.Text));

            if (cmdRegistrar.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("El registro del estudiante fue creado exitosamente!.");
                Limpiar_Campos();
            }
            else
            {
                MessageBox.Show("El registro del estudiante no pudo ser creado. Favor verificar.");
            };
            cnnRegistrar.Close();
        }

        private void EliminarEstudiante()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"Delete From Estudiante Where ID='{BoxIDE.Text}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.ExecuteNonQuery();

            consulta = $"Delete From calificacion Where ID_Estudiante='{BoxIDE.Text}'";
            SQLiteCommand comando2 = new SQLiteCommand(consulta, sql);

            comando2.ExecuteNonQuery();

            sql.Close();
        }

        private void Actualizar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"Update Estudiante Set Nombres='{BoxNameE.Text}', Apellidos='{BoxLastNE.Text}', ID_Carrera='{CBOCARRERA.Text}' Where ID='{BoxIDE.Text}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.ExecuteNonQuery();

            consulta = $"Update calificacion set Carrera = '{CBOCARRERA.Text}' where ID_Estudiante='{BoxIDE.Text}'";
            SQLiteCommand comando2 = new SQLiteCommand(consulta, sql);

            comando2.ExecuteNonQuery();

            sql.Close();
        }

        public bool Existe2()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "select * from estudiante where ID=@ID";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", BoxIDE.Text));

            SQLiteDataReader reader = comando.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                sql.Close();
                return false;
            }

            if (reader.Read())
            {
                if (BoxIDE.Text == reader.GetValue(reader.GetOrdinal("ID")).ToString())
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

        private void Generate_ID()
        {
            Random random = new Random();
            int number = random.Next(1, 9999999);

            while (Comprobar_ID(number))
            {
                number = random.Next(1, 9999999);
            }

            BoxIDE.Text = number.ToString();
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
                if (BoxIDE.Text == reader.GetValue(reader.GetOrdinal("ID")).ToString())
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

        private void button2_Click(object sender, EventArgs e)
        {
            Generate_ID();
        }

        private void Llenar_cboCarreras()
        {
            SQLiteConnection miConexion = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            miConexion.Open();
            SQLiteCommand comando = new SQLiteCommand("Select Nombre_Carrera from tbcarrera order by Nombre_Carrera", miConexion);
            SQLiteDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                CBOCARRERA.Items.Add(reader.GetValue(reader.GetOrdinal("Nombre_Carrera")).ToString());
            }

            reader.Close();
            miConexion.Close();
        }

        private void RegistrodeEstudiantes_Load(object sender, EventArgs e)
        {
            Llenar_cboCarreras();
            Habilitar_Botones();
            
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
            boxPasswordE.Text = Generate_Password();
        }
    }
}


