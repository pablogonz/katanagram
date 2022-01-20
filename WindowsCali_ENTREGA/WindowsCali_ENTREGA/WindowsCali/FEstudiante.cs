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
    public partial class FEstudiante : Form
    {
        public string id;
        public FEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionAsignatura seleccion = new SeleccionAsignatura();
            seleccion.idRecibido =id;
            seleccion.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (Existe_ID())
            {
                Modificar_Contraseña();
                MessageBox.Show("La contraseña fue ACTUALIZADA exitosamente!!", "Actualización Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                boxIDModify.Text = "";
                boxPasswordModify.Text = "";
            }
            else MessageBox.Show("La ID introducida no existe. Favor, verificar!!", "ID no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Modificar_Contraseña()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"update estudiante set Password = '{boxPasswordModify.Text}' where ID='{boxIDModify.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            cmd.ExecuteNonQuery();

            sql.Close();
        }

        private bool Existe_ID()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "select * from estudiante where ID=@ID";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", boxIDModify.Text));

            SQLiteDataReader reader = comando.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                sql.Close();
                return false;
            }

            if (reader.Read())
            {
                if (boxIDModify.Text == reader.GetValue(reader.GetOrdinal("ID")).ToString())
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

        private void btnReporte_Calif_Click(object sender, EventArgs e)
        {
            ReporteCalificacionesEstudiante reporte = new ReporteCalificacionesEstudiante();
            reporte.id = IDOculta.Text;
            reporte.ShowDialog();
        }

        private void FEstudiante_Load(object sender, EventArgs e)
        {
            IDOculta.Text = id;
            boxIDModify.Text = id;
        }

        private void btnRetiro_Asig_Click(object sender, EventArgs e)
        {
            fRetiro_Asignatura miF = new fRetiro_Asignatura();
            miF.ID_Est = id;
            miF.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
