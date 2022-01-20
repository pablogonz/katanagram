using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace WindowsCali
{
    public partial class SeleccionAsignatura : Form
    {
        public SeleccionAsignatura()
        {
            InitializeComponent();
        }
        public string idRecibido;

        private void Data_Asignaturas()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "select * from asignatura Where Clave Not In (Select Clave_Asignatura from tbregistro_selecciones Where Estatus_Seleccion<>'Retiro') Order by Nombre_Asignatura";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            dataGridView1.Refresh();

            var adapter = new SQLiteDataAdapter(cmd);
            using (var dt = new DataTable())
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sql.Close();
        }

        private void SeleccionAsignatura_Load(object sender, EventArgs e)
        {
            Data_Asignaturas();
        }


        private void Cargar_Datagrid()
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (cboOpciones_Asignatura.SelectedIndex==0 || cboOpciones_Asignatura.Text.Length==0)
            {
                Cargar_fRegistrar_Seleccion();
            }

            if (cboOpciones_Asignatura.SelectedIndex == 1)
            {
                Retirar_Asignatura();
            }
        }

        private void Cargar_fRegistrar_Seleccion()
        {
            string miClaveAsig = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();

            fRegistrar_Seleccion miForm = new fRegistrar_Seleccion();
            miForm.miClave_Asignatura = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
            miForm.miID_Estudiante = idRecibido;
            miForm.miProfesor_Asignado = dataGridView1.CurrentRow.Cells["Profesor_Asignado"].Value.ToString();

            //dataGridView1.;
            miForm.ShowDialog();
        }

        private void Retirar_Asignatura()
        {
            string miClaveAsig = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();

            fRetiro_Asignatura miForm = new fRetiro_Asignatura();
            miForm.Clave_Asig = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
            miForm.ID_Est = idRecibido;
            miForm.Profesor_Asig = dataGridView1.CurrentRow.Cells["Profesor_Asignado"].Value.ToString();
            miForm.ShowDialog();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Cargar_Asignaturas(int Opcion)
        {
            string miConsulta;

            if (Opcion == 1) 
            { 
                miConsulta = "select * from asignatura Where Clave Not In (Select Clave_Asignatura from tbregistro_selecciones) Order by Nombre_Asignatura";
            } else miConsulta = "select * from asignatura Where Clave In (Select Clave_Asignatura from tbregistro_selecciones Where Estatus_Seleccion<>'Retiro') Order by Nombre_Asignatura";

            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            SQLiteCommand cmd = new SQLiteCommand(miConsulta, sql);
            dataGridView1.Refresh();

            var adapter = new SQLiteDataAdapter(cmd);
            using (var dt = new DataTable())
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            sql.Close();
        }


        private void cboOpciones_Asignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboOpciones_Asignatura.SelectedIndex)
            {
                case 0:
                    // Asignaturas Disponibles.
                    Cargar_Asignaturas(1);
                    break;
                case 1:
                    //Asignaturas Seleccionadas.
                    Cargar_Asignaturas(2);
                    break;
            }
        }

        private void SeleccionAsignatura_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("activated");
        }
    }
}
