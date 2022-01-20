namespace WindowsCali
{
    partial class QueDeseaRegistra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueDeseaRegistra));
            this.BRegistrarE = new System.Windows.Forms.Button();
            this.BRegistrarP = new System.Windows.Forms.Button();
            this.BRegistrarC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BRegistrarA = new System.Windows.Forms.Button();
            this.btnPuntosHonor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BRegistrarE
            // 
            this.BRegistrarE.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BRegistrarE.Location = new System.Drawing.Point(558, 63);
            this.BRegistrarE.Name = "BRegistrarE";
            this.BRegistrarE.Size = new System.Drawing.Size(88, 39);
            this.BRegistrarE.TabIndex = 2;
            this.BRegistrarE.Text = "Estudiantes";
            this.BRegistrarE.UseVisualStyleBackColor = true;
            this.BRegistrarE.Click += new System.EventHandler(this.BRegistrarE_Click);
            // 
            // BRegistrarP
            // 
            this.BRegistrarP.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BRegistrarP.Location = new System.Drawing.Point(558, 128);
            this.BRegistrarP.Name = "BRegistrarP";
            this.BRegistrarP.Size = new System.Drawing.Size(88, 39);
            this.BRegistrarP.TabIndex = 5;
            this.BRegistrarP.Text = "Profesores";
            this.BRegistrarP.UseVisualStyleBackColor = true;
            this.BRegistrarP.Click += new System.EventHandler(this.BRegistrarP_Click);
            // 
            // BRegistrarC
            // 
            this.BRegistrarC.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BRegistrarC.Location = new System.Drawing.Point(558, 192);
            this.BRegistrarC.Name = "BRegistrarC";
            this.BRegistrarC.Size = new System.Drawing.Size(88, 39);
            this.BRegistrarC.TabIndex = 7;
            this.BRegistrarC.Text = "Calificaciones";
            this.BRegistrarC.UseVisualStyleBackColor = true;
            this.BRegistrarC.Click += new System.EventHandler(this.BRegistrarC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccione";
            // 
            // BRegistrarA
            // 
            this.BRegistrarA.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BRegistrarA.Location = new System.Drawing.Point(558, 252);
            this.BRegistrarA.Name = "BRegistrarA";
            this.BRegistrarA.Size = new System.Drawing.Size(88, 39);
            this.BRegistrarA.TabIndex = 10;
            this.BRegistrarA.Text = "Asignaturas";
            this.BRegistrarA.UseVisualStyleBackColor = true;
            this.BRegistrarA.Click += new System.EventHandler(this.BRegistrarA_Click);
            // 
            // btnPuntosHonor
            // 
            this.btnPuntosHonor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntosHonor.Location = new System.Drawing.Point(12, 319);
            this.btnPuntosHonor.Name = "btnPuntosHonor";
            this.btnPuntosHonor.Size = new System.Drawing.Size(102, 39);
            this.btnPuntosHonor.TabIndex = 13;
            this.btnPuntosHonor.Text = "Reporte";
            this.btnPuntosHonor.UseVisualStyleBackColor = true;
            this.btnPuntosHonor.Click += new System.EventHandler(this.btnPuntosHonor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnUsuarios.Location = new System.Drawing.Point(558, 309);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(88, 39);
            this.btnUsuarios.TabIndex = 14;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // QueDeseaRegistra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 361);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnPuntosHonor);
            this.Controls.Add(this.BRegistrarA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BRegistrarC);
            this.Controls.Add(this.BRegistrarP);
            this.Controls.Add(this.BRegistrarE);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(826, 400);
            this.MinimumSize = new System.Drawing.Size(826, 400);
            this.Name = "QueDeseaRegistra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BRegistrarE;
        private System.Windows.Forms.Button BRegistrarP;
        private System.Windows.Forms.Button BRegistrarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BRegistrarA;
        private System.Windows.Forms.Button btnPuntosHonor;
        private System.Windows.Forms.Button btnUsuarios;
    }
}