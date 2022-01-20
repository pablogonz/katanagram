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
using System.IO;

namespace WindowsCali
{
    public partial class RegistroCalificaciones : Form
    {
        public RegistroCalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();
            string consulta = "select ID, Nombres || ' ' || Apellidos as Nombre_Alumno, ID_Carrera from Estudiante Where ID=@ID";

            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@ID", BoxID_Est.Text));

            SQLiteDataReader miLector = comando.ExecuteReader();

            if (miLector.Read())
            {
                BoxID_Est.Text = miLector[0].ToString();
                BoxNameAlumno.Text = miLector[1].ToString();
                BoxCarrera_Estudiante.Text = miLector[2].ToString();

                miLector.Close();
                sql.Close();
            }
            else
            {
                MessageBox.Show("No existe estudiante asociado al ID digitado. Favor verificar!.");
                Limpiar_Campos();

                miLector.Close();
                sql.Close();
            }
        }

        private void Limpiar_Campos()
        {
            BoxID_Est.Text = "";
            BoxNameAlumno.Text = "";
            BoxCarrera_Estudiante.Text = "";
            BoxClave_Asignatura.Text = "";
            BoxNombre_Asignatura.Text = "";
            BoxCalificacion_Estudiante.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "SELECT Clave, Nombre_Asignatura, Cantidad_Creditos from Asignatura where Clave = @Clave_Asignatura";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@Clave_Asignatura", BoxClave_Asignatura.Text));

            SQLiteDataReader miLector = comando.ExecuteReader();

            if (miLector.Read())
            {
                BoxClave_Asignatura.Text = miLector[0].ToString();
                BoxNombre_Asignatura.Text = miLector[1].ToString();

                miLector.Close();
                sql.Close();
            }
            else
            {
                MessageBox.Show("No existe asignatura asociado al ID digitado. Favor verificar!.");

                BoxClave_Asignatura.Text = "";
                BoxNombre_Asignatura.Text = "";

                miLector.Close();
                sql.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");

            sql.Open();

            string consulta = "INSERT INTO Calificacion(ID_Estudiante, Carrera, Clave_Asignatura, Valor_Calificacion, Nota_Equivalente, Alumno) VALUES(@ID_Estudiante, @Carrera, @Clave_Asignatura, @Valor_Calificacion, @Nota_Equivalente, @Alumno)";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            switch (ValidarControles())
            {
                case true:

                    if (ComprobarCalificaciones() == false)
                    {
                        if (Can_Convert(BoxCalificacion_Estudiante.Text) && !(int.Parse(BoxCalificacion_Estudiante.Text) > 100) && !(int.Parse(BoxCalificacion_Estudiante.Text) < 0))
                        {
                            string miNota = Calificar_Nota(BoxCalificacion_Estudiante.Text.ToString());

                            comando.Parameters.Clear();
                            comando.Parameters.Add(new SQLiteParameter("@ID_Estudiante", BoxID_Est.Text));
                            comando.Parameters.Add(new SQLiteParameter("@Carrera", BoxCarrera_Estudiante.Text));
                            comando.Parameters.Add(new SQLiteParameter("@Clave_Asignatura", BoxClave_Asignatura.Text));
                            comando.Parameters.Add(new SQLiteParameter("@Valor_Calificacion", BoxCalificacion_Estudiante.Text));
                            comando.Parameters.Add(new SQLiteParameter("@Nota_Equivalente", miNota));
                            comando.Parameters.Add(new SQLiteParameter("@Alumno", BoxNameAlumno.Text));

                            if (comando.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("La calificación fue CREADA exitosamente!");
                                Limpiar_Campos();
                                Habilitar_Botones(true);
                                sql.Close();
                            }
                            else
                            {
                                MessageBox.Show("Se ha generado un error y no pudo crearse el registro. Favor verificar.");
                                sql.Close();
                            }  
                        }
                        else
                        {
                            MessageBox.Show("Valor introducido inválido. Favor, escriba un valor numérico entre 0 y 100!!");
                            sql.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La calificación ya está registrada.");
                        sql.Close();
                    }

                break;

                case false:
                    MessageBox.Show("Existen campos en blanco. Favor verificar!.");

                    sql.Close();
                break;
            }
        }

        private void Habilitar_Botones(Boolean valor=true)
        {
            button3.Enabled = valor;
            bActualizar.Enabled = !valor;
            bEliminar.Enabled = !valor;

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            switch (BoxID_Est.TextLength > 0 && BoxClave_Asignatura.TextLength > 0)
            {
                case true:

                    if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (ComprobarCalificaciones() == true)
                        {
                            Eliminar();
                            MessageBox.Show("La calificación fue ELIMINADA exitosamente!");
                            Habilitar_Botones(true);
                            Limpiar_Campos();
                        }
                        else MessageBox.Show("La calificación no existe."); 
                    }

                    break;

                case false: MessageBox.Show("Existen campos en blanco. Favor verificar!."); break;
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            if (BoxID_Est.TextLength > 0 && BoxClave_Asignatura.TextLength > 0)
            {
                switch (ComprobarCalificaciones())
                {
                    case true:
                        Actualizar();
                        MessageBox.Show("La calificación fue ACTUALIZADA exitosamente!");
                        Limpiar_Campos();
                        Habilitar_Botones(true);
                        break;

                    case false: MessageBox.Show("La calificación no existe."); break;
                }
            }
            else MessageBox.Show("Existen campos en blanco. Favor verificar!.");
        }

        private Boolean ValidarControles()
        {
            if (BoxID_Est.TextLength > 0 && BoxClave_Asignatura.TextLength > 0 && BoxCalificacion_Estudiante.TextLength > 0)
            {
                return true;
            }
            else return false;
        }

        public bool Existe2()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            string consulta = "select * from Asignatura where Clave=@Clave";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@Clave", BoxClave_Asignatura.Text));

            SQLiteDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (BoxClave_Asignatura.Text == reader.GetValue(reader.GetOrdinal("Clave")).ToString())
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
            else return false;
        }


        private string Calificar_Nota(string nota)
        {
            int Nota_equivalente = int.Parse(nota);
            string Nota_equiv = "";

            if (Nota_equivalente >= 90 && Nota_equivalente <= 100)
            {
                Nota_equiv = "A";
            }
            if (Nota_equivalente >= 80 && Nota_equivalente <= 89)
            {
                Nota_equiv = "B";
            }
            if (Nota_equivalente >= 70 && Nota_equivalente <= 79)
            {
                Nota_equiv = "C";
            }
            if (Nota_equivalente >= 60 && Nota_equivalente <= 69)
            {
                Nota_equiv = "D";
            }
            if (Nota_equivalente <= 59 && Nota_equivalente >= 0)
            {
                Nota_equiv = "F";
            }

            return Nota_equiv; 
        }

        private bool Can_Convert(string nota)
        {
            int notaC;

            if (int.TryParse(nota, out notaC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ComprobarCalificaciones()
        {
            string consulta, id = "", clave = "";

            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            consulta = $"select * from calificacion where ID_Estudiante = '{BoxID_Est.Text}' AND Clave_Asignatura = '{BoxClave_Asignatura.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetValue(reader.GetOrdinal("ID_Estudiante")).ToString();
                clave = reader.GetValue(reader.GetOrdinal("Clave_Asignatura")).ToString();
            }

            if (BoxID_Est.Text == id && BoxClave_Asignatura.Text == clave)
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

        private void Eliminar()
        {
            string consulta;

            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            consulta = $"delete from calificacion where ID_Estudiante = '{BoxID_Est.Text}' AND Clave_Asignatura = '{BoxClave_Asignatura.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            cmd.ExecuteNonQuery();

            sql.Close();
        }

        private void Actualizar()
        {
            string consulta, equivalente;

            SQLiteConnection sql = new SQLiteConnection("Data Source= DataBaseWindowsCali");
            sql.Open();

            equivalente = Calificar_Nota(BoxCalificacion_Estudiante.Text);

            consulta = $"update calificacion set Valor_Calificacion = '{BoxCalificacion_Estudiante.Text}', Nota_Equivalente = '{equivalente}' where ID_Estudiante = '{BoxID_Est.Text}' AND Clave_Asignatura = '{BoxClave_Asignatura.Text}'";
            SQLiteCommand cmd = new SQLiteCommand(consulta, sql);

            cmd.ExecuteNonQuery();

            sql.Close();
        }
    }
}

