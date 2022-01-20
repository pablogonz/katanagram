using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;

namespace WindowsCali
{
    public partial class frmPuntosHonor : Form
    {
        public frmPuntosHonor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Indice_Academico();
        }

        private void Indice_Academico()
        {
            string[] id, nota, credito, honor, alumno;
            string consulta;
            int c = 0, b = 0, cantidad = 0;

            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            consulta = "select count(*) as Contar from(select distinct ID_Estudiante from vwpuntoshonor)";
            SQLiteCommand cmd1 = new SQLiteCommand(consulta, sql);

            SQLiteDataReader leerCantidad = cmd1.ExecuteReader();

            if (leerCantidad.Read())
            {
                cantidad = int.Parse(leerCantidad.GetValue(leerCantidad.GetOrdinal("Contar")).ToString()); 
            }

            id = new string[cantidad];
            nota = new string[cantidad];
            credito = new string[cantidad];
            honor = new string[cantidad];
            alumno = new string[cantidad];
            double[] indice = new double[cantidad];
            
            consulta = "select distinct ID_Estudiante from vwpuntoshonor";
            SQLiteCommand cmd2 = new SQLiteCommand(consulta, sql);

            SQLiteDataReader readerID = cmd2.ExecuteReader();

            for (int i = 0; readerID.Read() == true; i++)
            {
                id[i] = readerID.GetValue(readerID.GetOrdinal("ID_Estudiante")).ToString();
            }
            readerID.Close();

            foreach (var identidad in id)
            {
                consulta = $"select ID_Estudiante, Alumno, SUM(Cantidad_Creditos) as Creditos, SUM(Puntos_Honor) as PuntosHonor from vwpuntoshonor where ID_Estudiante = '{identidad}'";
                SQLiteCommand cmd3 = new SQLiteCommand(consulta, sql);

                SQLiteDataReader cphReader = cmd3.ExecuteReader();

                if (cphReader.Read())
                {
                    nota[c] = cphReader.GetValue(cphReader.GetOrdinal("PuntosHonor")).ToString();
                    credito[c] = cphReader.GetValue(cphReader.GetOrdinal("Creditos")).ToString();
                    alumno[c] = cphReader.GetValue(cphReader.GetOrdinal("Alumno")).ToString();

                    indice[c] = double.Parse(nota[c]) / double.Parse(credito[c]);
                    honor[c] = CalcularHonor(indice[c]);
                }

                c++;
                cphReader.Close();
            }

            foreach (var ind in indice)
            {
                DataGridViewRow view = new DataGridViewRow();
                view.CreateCells(dataGridView1);

                view.Cells[0].Value = id[b];
                view.Cells[1].Value = alumno[b];
                view.Cells[2].Value = ind;
                view.Cells[3].Value = honor[b];

                dataGridView1.Rows.Add(view);
                b++;
            }
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            sql.Close();
        }

        private string CalcularHonor(double indice)
        {
            if (indice >= 3.80 && indice <= 4.00)
            {
                return "Summa Cum Laude";
            }
            else if(indice >= 3.50)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); 
            {
                save.Filter = "Archivo CSV (*.csv)|*.csv"; 
                save.FileName = "Registro Indice Academico";
                save.Title = "Exportar RIA";
            }

            if (save.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csv = new StringBuilder();

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (i == dataGridView1.Columns.Count - 1)
                    {
                        csv.Append(String.Format("\"{0}\"", dataGridView1.Columns[i].HeaderText));
                    }
                    else
                    {
                        csv.Append(String.Format("\"{0}\";", dataGridView1.Columns[i].HeaderText));
                    }
                }
                csv.AppendLine();

                for(int c = 0; c < dataGridView1.Rows.Count; c++)
                {
                    for(int d = 0; d < dataGridView1.Columns.Count; d++)
                    {
                        if(d == dataGridView1.Columns.Count - 1)
                        {
                            csv.Append(String.Format("\"{0}\"", dataGridView1.Rows[c].Cells[d].Value));
                        }
                        else
                        {
                            csv.Append(String.Format("\"{0}\";", dataGridView1.Rows[c].Cells[d].Value));
                        }
                    }
                    csv.AppendLine();
                }
                StreamWriter writer = new StreamWriter(save.FileName, false, Encoding.Default);
                writer.Write(csv.ToString());
                writer.Close();
            }

        }
    }
}
