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
    public partial class IndiceEstudiante : Form
    {
        public string id;
        public IndiceEstudiante()
        {
            InitializeComponent();
        }

        private void IndiceEstudiante_Load(object sender, EventArgs e)
        {
            textID.Text = id;
            Generate_Indice();
        }

        private void Generate_Indice()
        {
            string nota, credito, honor = "", alumno = "", consulta;
            double indice = 0;

            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            consulta = $"select ID_Estudiante, Alumno, SUM(Cantidad_Creditos) as Creditos, SUM(Puntos_Honor) as PuntosHonor from vwpuntoshonor where ID_Estudiante = '{textID.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nota = reader.GetValue(reader.GetOrdinal("PuntosHonor")).ToString();
                credito = reader.GetValue(reader.GetOrdinal("Creditos")).ToString();
                alumno = reader.GetValue(reader.GetOrdinal("Alumno")).ToString();

                indice = double.Parse(nota) / double.Parse(credito);
                honor = CalcularHonor(indice);
            }

            reader.Close();

            DataGridViewRow view = new DataGridViewRow();
            view.CreateCells(dataGridView1);

            view.Cells[0].Value = textID.Text;
            view.Cells[1].Value = alumno;
            view.Cells[2].Value = indice;
            view.Cells[3].Value = honor;

            dataGridView1.Rows.Add(view);
        }

        private string CalcularHonor(double indice)
        {
            if (indice >= 3.80 && indice <= 4.00)
            {
                return "Summa Cum Laude";
            }
            else if (indice >= 3.50)
            {
                return "Magna Cum Laude";
            }
            else if (indice >= 3.20)
            {
                return "Cum Laude";
            }
            else
            {
                return "Sin Honor";
            }
        }
    }
}
