using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsCali
{
    public partial class fRetiro_Asignatura : Form
    {
        public fRetiro_Asignatura()
        {
            InitializeComponent();
        }
        public string Clave_Asig, ID_Est, Profesor_Asig;

        private void txtClave_Asignatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtClave_Asignatura.Text = Clave_Asig;
            txtID_Estudiante.Text = ID_Est;
            txtProfesor_Asignatura.Text = Profesor_Asig;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SQLiteConnection miCnn = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            miCnn.Open();

            string consulta = "Update tbRegistro_Selecciones set Estatus_Seleccion='Retiro' where Clave_Asignatura=@Clave_Asignatura and ID_Estudiante=@ID_Estudiante";
            SQLiteCommand miCmd = new SQLiteCommand(consulta, miCnn);

            miCmd.Parameters.Clear();
            miCmd.Parameters.Add(new SQLiteParameter("@Clave_Asignatura", Clave_Asig));
            miCmd.Parameters.Add(new SQLiteParameter("@ID_Estudiante", ID_Est));

            if (miCmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Has retirado la asignatura satisfactoriamente!");

            }
            else MessageBox.Show("No se ha podido retirar la asignatura seleccionada. Favor verificar.");

            miCnn.Close();
            this.Close();
        }
    }
}
