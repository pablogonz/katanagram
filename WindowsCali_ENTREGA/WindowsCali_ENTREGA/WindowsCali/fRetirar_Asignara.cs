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

namespace WindowsCali
{
    public partial class fRegistrar_Seleccion : Form
    {
        public fRegistrar_Seleccion()
        {
            InitializeComponent();
        }

        public string miID_Estudiante, miClave_Asignatura, miProfesor_Asignado, miEstatus_Seleccion, miFecha_Seleccion;

        private void txtProfesor_Asignatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_Asignatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Estudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtID_Estudiante.Text = miID_Estudiante;
            txtClave_Asignatura.Text = miClave_Asignatura;
            txtProfesor_Asignatura.Text = miProfesor_Asignado;
            cboEstatus_Seleccion.Text = miEstatus_Seleccion;

            //miFecha_Seleccion.
        }

        private Boolean Verificar_Campos()
        {
            if (txtID_Estudiante.TextLength == 0 && txtClave_Asignatura.TextLength == 0 && txtProfesor_Asignatura.TextLength == 0 && cboEstatus_Seleccion.SelectedIndex > 0 && dtpFecha_Seleccion.Value.ToString().Length == 0)
            {
                return false;
            } else return true;
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Verificar_Campos())
            {
                SQLiteConnection miCnn = new SQLiteConnection("Data Source = DataBaseWindowsCali");
                miCnn.Open();

                //string consulta = "Insert Into tbRegistro_Selecciones (ID_Registro, ID_Estudiante, Clave_Asignatura, Profesor_Asignado, Estatus_Seleccion, Fecha_Seleccion) Values (@ID_Registro, @ID_Estudiante, @Clave_Asignatura, @Profesor_Asignado, @Estatus_Seleccion, @Fecha_Seleccion)";

                string consulta = "Insert Into tbRegistro_Selecciones(ID_Registro, ID_Estudiante, Clave_Asignatura, Profesor_Asignado, Estatus_Seleccion, Fecha_Seleccion) values" +
                                "(@ID_Registro, @ID_Estudiante, @Clave_Asignatura, @Profesor_Asignado, @Estatus_Seleccion, @Fecha_Seleccion)";


                SQLiteCommand cmd = new SQLiteCommand(consulta,miCnn);
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SQLiteParameter("@ID_Registro", 0));
                cmd.Parameters.Add(new SQLiteParameter("@ID_Estudiante", txtID_Estudiante.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Clave_Asignatura", txtClave_Asignatura.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Profesor_Asignado", txtProfesor_Asignatura.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Estatus_Seleccion", cboEstatus_Seleccion.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Fecha_Seleccion", dtpFecha_Seleccion.Text));

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("La asignatura ha sido seleccionada satisfactoriamente.");
                    miCnn.Close();
                    this.Close();
                }
                else MessageBox.Show("Se ha producido un error y no ha sido seleccionada la asignatura. Favor Verificar");
            }
            else MessageBox.Show("Existen campos en blanco. Favor verificar.");
        }
    }
}
