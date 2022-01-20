namespace WindowsCali
{
    partial class FEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEstudiante));
            this.btnSeleccionar_Asig = new System.Windows.Forms.Button();
            this.btnReporte_Calif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPasswordModify = new System.Windows.Forms.TextBox();
            this.boxIDModify = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDOculta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar_Asig
            // 
            this.btnSeleccionar_Asig.Location = new System.Drawing.Point(442, 43);
            this.btnSeleccionar_Asig.Name = "btnSeleccionar_Asig";
            this.btnSeleccionar_Asig.Size = new System.Drawing.Size(177, 36);
            this.btnSeleccionar_Asig.TabIndex = 0;
            this.btnSeleccionar_Asig.Text = "Selección de asignaturas";
            this.btnSeleccionar_Asig.UseVisualStyleBackColor = true;
            this.btnSeleccionar_Asig.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte_Calif
            // 
            this.btnReporte_Calif.Location = new System.Drawing.Point(653, 43);
            this.btnReporte_Calif.Name = "btnReporte_Calif";
            this.btnReporte_Calif.Size = new System.Drawing.Size(177, 36);
            this.btnReporte_Calif.TabIndex = 1;
            this.btnReporte_Calif.Text = "Reporte de Calificaciones";
            this.btnReporte_Calif.UseVisualStyleBackColor = true;
            this.btnReporte_Calif.Click += new System.EventHandler(this.btnReporte_Calif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonModificar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxPasswordModify);
            this.groupBox1.Controls.Add(this.boxIDModify);
            this.groupBox1.Location = new System.Drawing.Point(499, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar contraseña";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(102, 70);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(86, 23);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña nueva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // boxPasswordModify
            // 
            this.boxPasswordModify.Location = new System.Drawing.Point(183, 34);
            this.boxPasswordModify.MaxLength = 20;
            this.boxPasswordModify.Name = "boxPasswordModify";
            this.boxPasswordModify.Size = new System.Drawing.Size(100, 20);
            this.boxPasswordModify.TabIndex = 1;
            // 
            // boxIDModify
            // 
            this.boxIDModify.Enabled = false;
            this.boxIDModify.Location = new System.Drawing.Point(7, 34);
            this.boxIDModify.MaxLength = 7;
            this.boxIDModify.Name = "boxIDModify";
            this.boxIDModify.Size = new System.Drawing.Size(100, 20);
            this.boxIDModify.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // IDOculta
            // 
            this.IDOculta.Enabled = false;
            this.IDOculta.Location = new System.Drawing.Point(13, 43);
            this.IDOculta.Name = "IDOculta";
            this.IDOculta.Size = new System.Drawing.Size(100, 20);
            this.IDOculta.TabIndex = 5;
            this.IDOculta.Visible = false;
            // 
            // FEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 329);
            this.Controls.Add(this.IDOculta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporte_Calif);
            this.Controls.Add(this.btnSeleccionar_Asig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Estudiante";
            this.Load += new System.EventHandler(this.FEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar_Asig;
        private System.Windows.Forms.Button btnReporte_Calif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPasswordModify;
        private System.Windows.Forms.TextBox boxIDModify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox IDOculta;
    }
}