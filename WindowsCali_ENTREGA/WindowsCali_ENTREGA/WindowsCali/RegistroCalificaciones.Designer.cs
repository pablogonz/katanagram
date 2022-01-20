namespace WindowsCali
{
    partial class RegistroCalificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCalificaciones));
            this.BoxID_Est = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BBuscarC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxCarrera_Estudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxClave_Asignatura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxNombre_Asignatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxCalificacion_Estudiante = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BoxNameAlumno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxID_Est
            // 
            this.BoxID_Est.Location = new System.Drawing.Point(12, 25);
            this.BoxID_Est.MaxLength = 7;
            this.BoxID_Est.Name = "BoxID_Est";
            this.BoxID_Est.Size = new System.Drawing.Size(79, 20);
            this.BoxID_Est.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Estudiante:";
            // 
            // BBuscarC
            // 
            this.BBuscarC.Location = new System.Drawing.Point(97, 23);
            this.BBuscarC.Name = "BBuscarC";
            this.BBuscarC.Size = new System.Drawing.Size(60, 23);
            this.BBuscarC.TabIndex = 2;
            this.BBuscarC.Text = "Buscar";
            this.BBuscarC.UseVisualStyleBackColor = true;
            this.BBuscarC.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carrera";
            // 
            // BoxCarrera_Estudiante
            // 
            this.BoxCarrera_Estudiante.Enabled = false;
            this.BoxCarrera_Estudiante.Location = new System.Drawing.Point(12, 104);
            this.BoxCarrera_Estudiante.Name = "BoxCarrera_Estudiante";
            this.BoxCarrera_Estudiante.Size = new System.Drawing.Size(165, 20);
            this.BoxCarrera_Estudiante.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave de asignatura que desea calificar:";
            // 
            // BoxClave_Asignatura
            // 
            this.BoxClave_Asignatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BoxClave_Asignatura.Location = new System.Drawing.Point(12, 147);
            this.BoxClave_Asignatura.MaxLength = 7;
            this.BoxClave_Asignatura.Name = "BoxClave_Asignatura";
            this.BoxClave_Asignatura.Size = new System.Drawing.Size(90, 20);
            this.BoxClave_Asignatura.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asignatura";
            // 
            // BoxNombre_Asignatura
            // 
            this.BoxNombre_Asignatura.Enabled = false;
            this.BoxNombre_Asignatura.Location = new System.Drawing.Point(12, 188);
            this.BoxNombre_Asignatura.Name = "BoxNombre_Asignatura";
            this.BoxNombre_Asignatura.Size = new System.Drawing.Size(165, 20);
            this.BoxNombre_Asignatura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calificacion:";
            // 
            // BoxCalificacion_Estudiante
            // 
            this.BoxCalificacion_Estudiante.Location = new System.Drawing.Point(12, 229);
            this.BoxCalificacion_Estudiante.MaxLength = 3;
            this.BoxCalificacion_Estudiante.Name = "BoxCalificacion_Estudiante";
            this.BoxCalificacion_Estudiante.Size = new System.Drawing.Size(79, 20);
            this.BoxCalificacion_Estudiante.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoxNameAlumno
            // 
            this.BoxNameAlumno.Enabled = false;
            this.BoxNameAlumno.Location = new System.Drawing.Point(12, 66);
            this.BoxNameAlumno.Name = "BoxNameAlumno";
            this.BoxNameAlumno.Size = new System.Drawing.Size(165, 20);
            this.BoxNameAlumno.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alumno";
            // 
            // bEliminar
            // 
            this.bEliminar.Enabled = false;
            this.bEliminar.Location = new System.Drawing.Point(97, 255);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(71, 28);
            this.bEliminar.TabIndex = 15;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Enabled = false;
            this.bActualizar.Location = new System.Drawing.Point(12, 255);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(71, 28);
            this.bActualizar.TabIndex = 16;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCali.Properties.Resources.How_to_take_great_notes_1;
            this.pictureBox1.Location = new System.Drawing.Point(211, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 292);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxNameAlumno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BoxCalificacion_Estudiante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxNombre_Asignatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BoxClave_Asignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxCarrera_Estudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBuscarC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxID_Est);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(628, 330);
            this.MinimumSize = new System.Drawing.Size(628, 330);
            this.Name = "RegistroCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxID_Est;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BBuscarC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxCarrera_Estudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxClave_Asignatura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxNombre_Asignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxCalificacion_Estudiante;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox BoxNameAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}