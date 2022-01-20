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

namespace WindowsCali
{
    public partial class RegistrarAsignatura : Form
    {
        private TextBox BoxClave;
        private Label label1;
        private TextBox BoxNombre;
        private Label label2;
        private ComboBox cboCreditos;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private PictureBox pictureBox1;

        private Button btnBuscar;
        private ComboBox cboCarrera;
        private Label label3;
        private Label label5;
        private ComboBox cboProfesor_Asignado;
        private Label label4;
        public string [] misIDProfesores= new string[40];

        public RegistrarAsignatura()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAsignatura));
            this.label4 = new System.Windows.Forms.Label();
            this.BoxClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCreditos = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProfesor_Asignado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clave de Asignatura";
            // 
            // BoxClave
            // 
            this.BoxClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BoxClave.Location = new System.Drawing.Point(15, 39);
            this.BoxClave.MaxLength = 7;
            this.BoxClave.Name = "BoxClave";
            this.BoxClave.Size = new System.Drawing.Size(112, 20);
            this.BoxClave.TabIndex = 10;
            this.BoxClave.TextChanged += new System.EventHandler(this.BoxClave_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre de Asignatura";
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(15, 80);
            this.BoxNombre.MaxLength = 20;
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(185, 20);
            this.BoxNombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Credito";
            // 
            // cboCreditos
            // 
            this.cboCreditos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreditos.FormattingEnabled = true;
            this.cboCreditos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboCreditos.Location = new System.Drawing.Point(15, 121);
            this.cboCreditos.Name = "cboCreditos";
            this.cboCreditos.Size = new System.Drawing.Size(64, 21);
            this.cboCreditos.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(56, 249);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(56, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(56, 283);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(133, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 28);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCali.Properties.Resources.Asignaturas;
            this.pictureBox1.Location = new System.Drawing.Point(206, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(15, 166);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(184, 21);
            this.cboCarrera.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Carrera";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Profesor Asignado";
            // 
            // cboProfesor_Asignado
            // 
            this.cboProfesor_Asignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfesor_Asignado.FormattingEnabled = true;
            this.cboProfesor_Asignado.Location = new System.Drawing.Point(16, 213);
            this.cboProfesor_Asignado.Name = "cboProfesor_Asignado";
            this.cboProfesor_Asignado.Size = new System.Drawing.Size(184, 21);
            this.cboProfesor_Asignado.TabIndex = 23;
            this.cboProfesor_Asignado.SelectedIndexChanged += new System.EventHandler(this.cboProfesor_Asignado_SelectedIndexChanged);
            // 
            // RegistrarAsignatura
            // 
            this.ClientSize = new System.Drawing.Size(690, 369);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboProfesor_Asignado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboCreditos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxClave);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asignaturas";
            this.Load += new System.EventHandler(this.RegistrarAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            // ORIGINAL string consulta = "SELECT Clave, Nombre_Asignatura, Cantidad_Creditos, ID_Carrera, Profesor_Asignado From Asignatura Where Clave=@Clave";
            string consulta = "select Clave, Nombre_Asignatura, Cantidad_Creditos, ID_Carrera, Nombre_Unificado_Profesor,Profesor_Asignado, ID_Profesor, Nombres_Profesor, Apellidos_Profesor, Password, Asignatura_Imparte from vwAsignatura_Profesor Where Clave=@Clave";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.Parameters.Clear();
            comando.Parameters.Add(new SQLiteParameter("@Clave", BoxClave.Text));

            SQLiteDataReader miLector = comando.ExecuteReader();

            if (miLector.Read())
            {
                BoxClave.Text = miLector[0].ToString();
                BoxNombre.Text = miLector[1].ToString();
                cboCreditos.Text = miLector[2].ToString();
                cboCarrera.Text = miLector[3].ToString();
                cboProfesor_Asignado.SelectedText= miLector[6].ToString();
                Habilitar_Botones(false);
            }
            else
            {
                MessageBox.Show("No existe asignatura registrado con el ID digitado.");
                Limpiar_Campos();
                Habilitar_Botones(true);
            }

            miLector.Close();
            sql.Close();
        
        }

        private void Habilitar_Botones(Boolean valor=true)
        {
            btnRegistrar.Enabled = valor;
            btnActualizar.Enabled = !valor;
            btnEliminar.Enabled = !valor;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = "INSERT INTO Asignatura(Clave, Nombre_Asignatura, Cantidad_Creditos, ID_Carrera, Profesor_Asignado) VALUES(@Clave, @Nombre_Asignatura, @Cantidad_Creditos, @ID_Carrera, @Profesor_Asignado)";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            switch (ValidarControles())
            {
                case true:

                if (!Existe2())
                {
                    comando.Parameters.Clear();
                    comando.Parameters.Add(new SQLiteParameter("@Clave", BoxClave.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Nombre_Asignatura", BoxNombre.Text));
                    comando.Parameters.Add(new SQLiteParameter("@Cantidad_Creditos", cboCreditos.Text));
                    comando.Parameters.Add(new SQLiteParameter("@ID_Carrera", cboCarrera.Text));
                    //comando.Parameters.Add(new SQLiteParameter("@Profesor_Asignado", misIDProfesores[cboProfesor_Asignado.SelectedIndex]));
                    comando.Parameters.Add(new SQLiteParameter("@Profesor_Asignado", cboProfesor_Asignado.SelectedText));

                        if (comando.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("La asignatura fue CREADA exitosamente!");
                        Limpiar_Campos();
                        Habilitar_Botones(true);
                    }
                    else MessageBox.Show("Se ha generado un error y no pudo crearse el registro. Favor verficar.");
                }
                else MessageBox.Show("Ya existe una asignatura registrada con ese ID. Favor verificar!");

                    break;

                case false: MessageBox.Show("Existen campos en blanco. Favor verificar!."); break;
            }

            sql.Close();
        }

        private void Limpiar_Campos()
        {
            BoxClave.Text = "";
            BoxNombre.Text = "";
            cboCreditos.SelectedIndex = -1;
            cboCarrera.SelectedIndex = -1;
            cboProfesor_Asignado.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            switch (ValidarControles())
            {
                case true:

                if (Existe2())
                {
                    Actualizar();
                    //MessageBox.Show("Los datos de la asignatura fueron ACTUALIZADOS exitosamente!");
                    //Limpiar_Campos();
                }
                else MessageBox.Show("No existen asignaturas asociadas a esa clave. Favor verificar!");

                    break;

                case false: MessageBox.Show("Existen campos en blanco. Favor verificar!."); break;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Existe2())
            {
                if (MessageBox.Show("¿Estás seguro de que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Eliminar();
                    MessageBox.Show("El registro de la asignatura fue BORRADO exitosamente!");
                    Limpiar_Campos(); 
                }
            }
            else MessageBox.Show("No existe asignatura alguna asociada a esa clave. Favor verificar!");
        }

        private void Eliminar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"Delete From Asignatura Where Clave='{BoxClave.Text}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            comando.ExecuteNonQuery();

            consulta = $"delete from calificacion where Clave_Asignatura = '{BoxClave.Text}'";
            SQLiteCommand comando2 = new SQLiteCommand(consulta, sql);

            comando2.ExecuteNonQuery();

            sql.Close();
        }

        private void Actualizar()
        {
            SQLiteConnection sql = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            sql.Open();

            string consulta = $"Update asignatura Set Nombre_Asignatura='{BoxNombre.Text}', Cantidad_Creditos='{cboCreditos.Text}', ID_Carrera = '{cboCarrera.Text}', Profesor_Asignado = '{cboProfesor_Asignado.Text}' Where Clave='{BoxClave.Text}'";
            SQLiteCommand comando = new SQLiteCommand(consulta, sql);

            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("La asignatura fue actualizada satisfactoriamente!");
                Habilitar_Botones(true);
                Limpiar_Campos();
            }
            else MessageBox.Show("La asignatura no pudo ser actualizada. Favor verificar!");
            

            sql.Close();
        }

        private Boolean ValidarControles()
        {
            if (BoxClave.TextLength > 0 && BoxNombre.TextLength > 0 && cboCreditos.SelectedIndex > 0 && cboProfesor_Asignado.SelectedIndex > 0)
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
            comando.Parameters.Add(new SQLiteParameter("@Clave", BoxClave.Text));

            SQLiteDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (BoxClave.Text == reader.GetValue(reader.GetOrdinal("Clave")).ToString())
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

        private void Llenar_cboCarreras()
        {
            SQLiteConnection miConexion = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            miConexion.Open();
            SQLiteCommand comando = new SQLiteCommand("Select Nombre_Carrera from tbcarrera order by Nombre_Carrera", miConexion);
            SQLiteDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cboCarrera.Items.Add(reader.GetValue(reader.GetOrdinal("Nombre_Carrera")).ToString());
            }

            reader.Close();
            miConexion.Close();
        }

        private void Llenar_cboProfesorAsignado()
        {
            //string[] misIDProfesores=new string[40];

            SQLiteConnection miConexion = new SQLiteConnection("Data Source = DataBaseWindowsCali");
            miConexion.Open();
            SQLiteCommand comando = new SQLiteCommand("Select ID_Profesor, Nombres_Profesor || ' ' || Apellidos_Profesor as Nombres_Profesor from profesor order by Nombres_Profesor", miConexion);
            SQLiteDataReader reader = comando.ExecuteReader();

            int cont1 = 0;

            while (reader.Read())
            {
               cboProfesor_Asignado.Items.Add(reader.GetValue(reader.GetOrdinal("Nombres_Profesor")).ToString());
                misIDProfesores[cont1] = reader.GetValue(reader.GetOrdinal("ID_Profesor")).ToString();
                cont1++;
            }

            reader.Close();
            miConexion.Close();
        }

        private void RegistrarAsignatura_Load(object sender, EventArgs e)
        {
            Llenar_cboCarreras();
            Llenar_cboProfesorAsignado();
            Habilitar_Botones(true);
        }

        private void BoxClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboProfesor_Asignado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
