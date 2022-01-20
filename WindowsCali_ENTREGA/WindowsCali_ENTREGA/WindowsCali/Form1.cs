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

namespace WindowsCali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string usuario = "FranciaM";
        string contra = "intec";
        string idEnviar;

        private void BLogin_Click(object sender, EventArgs e)
        {
            if (LogIn() || (BoxUser.Text == usuario && BoxPassword.Text == contra))
            {
                MessageBox.Show("Login exitoso");
                Limpiar();
                Form Login = new QueDeseaRegistra();
                Login.ShowDialog();
            }
            else MessageBox.Show("Usuario y/o contraseña incorrecta");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            if (BoxUser.Text == usuario && BoxPassword.Text == contra)
            {
                Registro registro = new Registro();
                registro.ShowDialog();
            }
            else MessageBox.Show("El usuario no es el administrador!!");
        }

        private void Limpiar()
        {
            BoxUser.Text = "";
            BoxPassword.Text = "";
        }

        private bool LogIn()
        {
            string User = "", pass = "";

            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from user where User='{BoxUser.Text}' AND vPass = '{BoxPassword.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User = reader.GetValue(reader.GetOrdinal("User")).ToString();
                pass = reader.GetValue(reader.GetOrdinal("vPass")).ToString();
            }

            reader.Close();
            sql.Close();

            if (BoxUser.Text == User && BoxPassword.Text == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form f = new QueDeseaRegistra();
            //f.ShowDialog();


            if (BoxUser.TextLength==0 || BoxPassword.TextLength==0)
            {
                MessageBox.Show("Existen campos vacíos. Favor verificar.");
            }
            else Confirmar_Usuario_Existe2();

            
        }

        public void Confirmar_Usuario_Existe()
        {

            string Usuario = "", Clave="", Tipo_Usuario = "";

            SQLiteConnection miConexion = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            miConexion.Open();

            //string consulta = "select User, vPass, Tipo_Usuario from user where User=@Usuario";
            string consulta = "Select distinct ID, Password, Tipo_Usuario from (select ID, Password, 'Estudiante' as Tipo_Usuario from estudiante union all select ID_Profesor as ID, Password, 'Profesor' as Tipo_Usuario from Profesor union all select User as ID, vPass as Password, Tipo_Usuario from user) a Where ID=@ID and Password=@Password";

            SQLiteCommand comando = new SQLiteCommand(consulta, miConexion);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", BoxUser.Text));
            comando.Parameters.Add(new SQLiteParameter("@Password", BoxPassword.Text));

            //Original comando.Parameters.Clear();
            //Original comando.Parameters.Add(new SQLiteParameter("@Usuario", BoxUser.Text));

            SQLiteDataReader miDataReader = comando.ExecuteReader();

            if (miDataReader.Read())
            {
                Usuario = miDataReader.GetValue(miDataReader.GetOrdinal("ID")).ToString();
                Clave = miDataReader.GetValue(miDataReader.GetOrdinal("Password")).ToString();
                Tipo_Usuario = miDataReader.GetValue(miDataReader.GetOrdinal("Tipo_Usuario")).ToString();

                miDataReader.Close();
                miConexion.Close();

                if (Usuario == BoxUser.Text && Clave == BoxPassword.Text)
                {
                    switch (Tipo_Usuario)
                    {
                        case "Administrador":
                            Form f = new QueDeseaRegistra();
                            f.ShowDialog();
                            
                            break;
                        case "Profesor":
                            // Pendiente crear formulario
                            Form f2 = new FProfesorCalificar();
                            f2.ShowDialog();
                            break;
                        case "Estudiante":
                            Form f3 = new FEstudiante();
                            f3.ShowDialog();

                            break;
                    }
                }
                else if (Existe_Estudiante() == true)
                {
                    FEstudiante f3 = new FEstudiante();
                    f3.id = BoxUser.Text;
                    f3.ShowDialog();
                }
                else if (Existe_Profesor() == true)
                {
                    Form f2 = new FProfesorCalificar();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Favor verificar.");
                    miDataReader.Close();
                    miConexion.Close();
                }
            }
            else if (Existe_Estudiante() == true)
            {
                FEstudiante f3 = new FEstudiante();
                f3.id = BoxUser.Text;
                f3.ShowDialog();
            }
            else if (Existe_Profesor() == true)
            {
                Form f2 = new FProfesorCalificar();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario digitado no existe. Favor verificar.");
                miDataReader.Close();
                miConexion.Close();
            }
        }

        public void Confirmar_Usuario_Existe2()
        {

            string Usuario = "", Clave = "", Tipo_Usuario = "";

            SQLiteConnection miConexion = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            miConexion.Open();

            string consulta = "Select distinct ID, Password, Tipo_Usuario from vwBuscar_Usuarios Where ID=@ID and Password=@Password";
            SQLiteCommand comando = new SQLiteCommand(consulta, miConexion);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", BoxUser.Text));
            comando.Parameters.Add(new SQLiteParameter("@Password", BoxPassword.Text));

            SQLiteDataReader miDataReader = comando.ExecuteReader();

            if (miDataReader.Read())
            {
                Usuario = miDataReader.GetValue(miDataReader.GetOrdinal("ID")).ToString();
                Clave = miDataReader.GetValue(miDataReader.GetOrdinal("Password")).ToString();
                Tipo_Usuario = miDataReader.GetValue(miDataReader.GetOrdinal("Tipo_Usuario")).ToString();
                idEnviar = BoxUser.Text;

                BoxUser.ResetText();
                BoxPassword.ResetText();

                miDataReader.Close();
                miConexion.Close();

                switch (Tipo_Usuario)
                {
                    case "Administrador":
                        Form f = new QueDeseaRegistra();
                        f.ShowDialog();
                        break;
                    case "Profesor":
                        Form f2 = new FProfesorCalificar();
                        f2.ShowDialog();
                        break;
                    case "Estudiante":
                        
                        FEstudiante f3 = new FEstudiante();
                        f3.id = idEnviar;
                        f3.ShowDialog();
                        break;
                }
            }
            else MessageBox.Show("Credenciales Incorrectas. Favor verificar.");

        }
        private bool Existe_Estudiante()
        {
            string User = "", pass = "";

            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from estudiante where ID='{BoxUser.Text}' AND Password = '{BoxPassword.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User = reader.GetValue(reader.GetOrdinal("ID")).ToString();
                pass = reader.GetValue(reader.GetOrdinal("Password")).ToString();
            }

            reader.Close();
            sql.Close();

            if (BoxUser.Text == User && BoxPassword.Text == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Existe_Profesor()
        {
            string User = "", pass = "";

            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from profesor where ID_Profesor='{BoxUser.Text}' AND Password = '{BoxPassword.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User = reader.GetValue(reader.GetOrdinal("ID_Profesor")).ToString();
                pass = reader.GetValue(reader.GetOrdinal("Password")).ToString();
            }

            reader.Close();
            sql.Close();

            if (BoxUser.Text == User && BoxPassword.Text == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
