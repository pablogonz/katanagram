using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsCali
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            BoxUser.Text = "";
            BoxPassword.Text = "";
        }

        private void Registrar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"insert into user(User, vPass) values('{BoxUser.Text}','{BoxPassword.Text}')";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            cmd.ExecuteNonQuery();

            sql.Close();
        }

        private bool Existe()
        {
            string User = "";

            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from user where User='{BoxUser.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User = reader.GetValue(reader.GetOrdinal("User")).ToString();
            }

            reader.Close();
            sql.Close();

            if (BoxUser.Text == User)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Existe())
            {
                Registrar();
                MessageBox.Show("Registro completado!!");
                Limpiar();
            }
            else MessageBox.Show("El usuario ya existe.");
        }

        private void Eliminar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"delete from user where User='{BoxUser.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            cmd.ExecuteNonQuery();

            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Existe())
            {
                if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Eliminar();
                    MessageBox.Show("Usuario eliminado correctamente!!");
                    Limpiar(); 
                }
            }
            else MessageBox.Show("El usuario no existe!!");
        }
    }
}
