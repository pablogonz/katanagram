namespace WindowsCali
{
    partial class RegistrodeProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeProfesores));
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNameP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxIDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxLastNP = new System.Windows.Forms.TextBox();
            this.RegistrarP = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerarPassword = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // BoxNameP
            // 
            this.BoxNameP.Location = new System.Drawing.Point(357, 54);
            this.BoxNameP.MaxLength = 20;
            this.BoxNameP.Name = "BoxNameP";
            this.BoxNameP.Size = new System.Drawing.Size(181, 20);
            this.BoxNameP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // BoxIDP
            // 
            this.BoxIDP.Enabled = false;
            this.BoxIDP.Location = new System.Drawing.Point(357, 117);
            this.BoxIDP.MaxLength = 7;
            this.BoxIDP.Name = "BoxIDP";
            this.BoxIDP.Size = new System.Drawing.Size(100, 20);
            this.BoxIDP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // BoxLastNP
            // 
            this.BoxLastNP.Location = new System.Drawing.Point(566, 54);
            this.BoxLastNP.MaxLength = 20;
            this.BoxLastNP.Name = "BoxLastNP";
            this.BoxLastNP.Size = new System.Drawing.Size(181, 20);
            this.BoxLastNP.TabIndex = 3;
            // 
            // RegistrarP
            // 
            this.RegistrarP.Location = new System.Drawing.Point(379, 296);
            this.RegistrarP.Name = "RegistrarP";
            this.RegistrarP.Size = new System.Drawing.Size(108, 27);
            this.RegistrarP.TabIndex = 7;
            this.RegistrarP.Text = "Registrar";
            this.RegistrarP.UseVisualStyleBackColor = true;
            this.RegistrarP.Click += new System.EventHandler(this.RegistrarP_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(516, 296);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(108, 27);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(649, 296);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(108, 27);
            this.bActualizar.TabIndex = 9;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(463, 226);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(108, 27);
            this.bBuscar.TabIndex = 10;
            this.bBuscar.Text = "Buscar ID";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(463, 114);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generar ID";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.Enabled = false;
            this.boxPassword.Location = new System.Drawing.Point(566, 117);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(100, 20);
            this.boxPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña";
            // 
            // buttonGenerarPassword
            // 
            this.buttonGenerarPassword.Location = new System.Drawing.Point(682, 114);
            this.buttonGenerarPassword.Name = "buttonGenerarPassword";
            this.buttonGenerarPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerarPassword.TabIndex = 14;
            this.buttonGenerarPassword.Text = "Generar";
            this.buttonGenerarPassword.UseVisualStyleBackColor = true;
            this.buttonGenerarPassword.Click += new System.EventHandler(this.buttonGenerarPassword_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 230);
            this.textBox1.MaxLength = 7;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(427, 174);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(181, 21);
            this.cboAsignaturas.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Asignatura";
            // 
            // RegistrodeProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGenerarPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.RegistrarP);
            this.Controls.Add(this.BoxLastNP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxIDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNameP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodeProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Profesores";
            this.Load += new System.EventHandler(this.RegistrodeProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNameP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxIDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxLastNP;
        private System.Windows.Forms.Button RegistrarP;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGenerarPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.Label label5;
    }
}