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
using System.Linq.Expressions;

namespace WindowsCali
{
    public partial class ReporteCalificacionesEstudiante : Form
    {
        public string id;
        public ReporteCalificacionesEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"select * from vwpuntoshonor where ID_Estudiante = '{textBox1.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            var adapter = new SQLiteDataAdapter(cmd);
            using (var dt = new DataTable())
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            sql.Close();
        }

        private void ReporteCalificacionesEstudiante_Load(object sender, EventArgs e)
        {
            textBox1.Text = id;
        }

        private void buttonIndice_Click(object sender, EventArgs e)
        {
            IndiceEstudiante indice = new IndiceEstudiante();
            indice.id = textBox1.Text;
            indice.ShowDialog();
        }
    }
}
