namespace WindowsCali
{
    partial class fRegistrar_Seleccion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha_Seleccion = new System.Windows.Forms.DateTimePicker();
            this.cboEstatus_Seleccion = new System.Windows.Forms.ComboBox();
            this.txtProfesor_Asignatura = new System.Windows.Forms.TextBox();
            this.txtClave_Asignatura = new System.Windows.Forms.TextBox();
            this.txtID_Estudiante = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFecha_Seleccion);
            this.groupBox1.Controls.Add(this.cboEstatus_Seleccion);
            this.groupBox1.Controls.Add(this.txtProfesor_Asignatura);
            this.groupBox1.Controls.Add(this.txtClave_Asignatura);
            this.groupBox1.Controls.Add(this.txtID_Estudiante);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Location = new System.Drawing.Point(109, 275);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(143, 25);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Seleccionar Asignatura";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clave Asignatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Profesor Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Selección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estatus Selección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Estudiante";
            // 
            // dtpFecha_Seleccion
            // 
            this.dtpFecha_Seleccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Seleccion.Location = new System.Drawing.Point(178, 198);
            this.dtpFecha_Seleccion.Name = "dtpFecha_Seleccion";
            this.dtpFecha_Seleccion.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha_Seleccion.TabIndex = 6;
            this.dtpFecha_Seleccion.Value = new System.DateTime(2020, 7, 17, 20, 44, 21, 0);
            // 
            // cboEstatus_Seleccion
            // 
            this.cboEstatus_Seleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstatus_Seleccion.FormattingEnabled = true;
            this.cboEstatus_Seleccion.Items.AddRange(new object[] {
            "Seleccionada",
            "Retiro",
            "Satisfactorio",
            "No Satisfactorio"});
            this.cboEstatus_Seleccion.Location = new System.Drawing.Point(178, 159);
            this.cboEstatus_Seleccion.Name = "cboEstatus_Seleccion";
            this.cboEstatus_Seleccion.Size = new System.Drawing.Size(100, 21);
            this.cboEstatus_Seleccion.TabIndex = 5;
            this.cboEstatus_Seleccion.SelectedIndexChanged += new System.EventHandler(this.cboEstatus_Seleccion_SelectedIndexChanged);
            // 
            // txtProfesor_Asignatura
            // 
            this.txtProfesor_Asignatura.Enabled = false;
            this.txtProfesor_Asignatura.Location = new System.Drawing.Point(178, 123);
            this.txtProfesor_Asignatura.Name = "txtProfesor_Asignatura";
            this.txtProfesor_Asignatura.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor_Asignatura.TabIndex = 3;
            this.txtProfesor_Asignatura.TextChanged += new System.EventHandler(this.txtProfesor_Asignatura_TextChanged);
            // 
            // txtClave_Asignatura
            // 
            this.txtClave_Asignatura.Enabled = false;
            this.txtClave_Asignatura.Location = new System.Drawing.Point(178, 87);
            this.txtClave_Asignatura.Name = "txtClave_Asignatura";
            this.txtClave_Asignatura.Size = new System.Drawing.Size(100, 20);
            this.txtClave_Asignatura.TabIndex = 1;
            this.txtClave_Asignatura.TextChanged += new System.EventHandler(this.txtClave_Asignatura_TextChanged);
            // 
            // txtID_Estudiante
            // 
            this.txtID_Estudiante.Enabled = false;
            this.txtID_Estudiante.Location = new System.Drawing.Point(178, 51);
            this.txtID_Estudiante.Name = "txtID_Estudiante";
            this.txtID_Estudiante.Size = new System.Drawing.Size(100, 20);
            this.txtID_Estudiante.TabIndex = 0;
            this.txtID_Estudiante.TextChanged += new System.EventHandler(this.txtID_Estudiante_TextChanged);
            // 
            // fRegistrar_Seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "fRegistrar_Seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Asignaturas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfesor_Asignatura;
        private System.Windows.Forms.TextBox txtClave_Asignatura;
        private System.Windows.Forms.TextBox txtID_Estudiante;
        private System.Windows.Forms.ComboBox cboEstatus_Seleccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha_Seleccion;
        private System.Windows.Forms.Button btnConfirmar;
    }
}