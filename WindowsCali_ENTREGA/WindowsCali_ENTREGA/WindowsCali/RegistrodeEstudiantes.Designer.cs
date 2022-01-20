namespace WindowsCali
{
    partial class RegistrodeEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeEstudiantes));
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNameE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxLastNE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxIDE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CBOCARRERA = new System.Windows.Forms.ComboBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxPasswordE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerarPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // BoxNameE
            // 
            this.BoxNameE.Location = new System.Drawing.Point(12, 39);
            this.BoxNameE.MaxLength = 20;
            this.BoxNameE.Name = "BoxNameE";
            this.BoxNameE.Size = new System.Drawing.Size(198, 20);
            this.BoxNameE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // BoxLastNE
            // 
            this.BoxLastNE.Location = new System.Drawing.Point(12, 78);
            this.BoxLastNE.MaxLength = 20;
            this.BoxLastNE.Name = "BoxLastNE";
            this.BoxLastNE.Size = new System.Drawing.Size(198, 20);
            this.BoxLastNE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // BoxIDE
            // 
            this.BoxIDE.Enabled = false;
            this.BoxIDE.Location = new System.Drawing.Point(12, 117);
            this.BoxIDE.MaxLength = 7;
            this.BoxIDE.Name = "BoxIDE";
            this.BoxIDE.Size = new System.Drawing.Size(100, 20);
            this.BoxIDE.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrera";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBOCARRERA
            // 
            this.CBOCARRERA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOCARRERA.FormattingEnabled = true;
            this.CBOCARRERA.Location = new System.Drawing.Point(12, 204);
            this.CBOCARRERA.Name = "CBOCARRERA";
            this.CBOCARRERA.Size = new System.Drawing.Size(179, 21);
            this.CBOCARRERA.TabIndex = 6;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(57, 331);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 28);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(57, 365);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(100, 28);
            this.bActualizar.TabIndex = 9;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(110, 258);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(100, 28);
            this.bBuscar.TabIndex = 13;
            this.bBuscar.Text = "Buscar ID";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generar ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsCali.Properties.Resources.EstuMichigan;
            this.pictureBox1.Location = new System.Drawing.Point(216, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 15;
            // 
            // boxPasswordE
            // 
            this.boxPasswordE.Enabled = false;
            this.boxPasswordE.Location = new System.Drawing.Point(12, 156);
            this.boxPasswordE.Name = "boxPasswordE";
            this.boxPasswordE.Size = new System.Drawing.Size(100, 20);
            this.boxPasswordE.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contraseña";
            // 
            // buttonGenerarPassword
            // 
            this.buttonGenerarPassword.Location = new System.Drawing.Point(116, 154);
            this.buttonGenerarPassword.Name = "buttonGenerarPassword";
            this.buttonGenerarPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerarPassword.TabIndex = 5;
            this.buttonGenerarPassword.Text = "Generar";
            this.buttonGenerarPassword.UseVisualStyleBackColor = true;
            this.buttonGenerarPassword.Click += new System.EventHandler(this.buttonGenerarPassword_Click);
            // 
            // RegistrodeEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 403);
            this.Controls.Add(this.buttonGenerarPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxPasswordE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.CBOCARRERA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxIDE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxLastNE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNameE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(854, 444);
            this.MinimumSize = new System.Drawing.Size(854, 444);
            this.Name = "RegistrodeEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            this.Load += new System.EventHandler(this.RegistrodeEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNameE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxLastNE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxIDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBOCARRERA;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox boxPasswordE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerarPassword;
    }
}