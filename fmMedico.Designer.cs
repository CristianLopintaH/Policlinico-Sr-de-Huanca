namespace AppControlClinica
{
    partial class fmMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMedico));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGrabar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bConsulta = new System.Windows.Forms.Button();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApeMat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApePate = new System.Windows.Forms.TextBox();
            this.tbCodigoMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.bSalir);
            this.panel3.Controls.Add(this.bGrabar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 50);
            this.panel3.TabIndex = 0;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.bSalir.Location = new System.Drawing.Point(276, 15);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bGrabar
            // 
            this.bGrabar.BackColor = System.Drawing.Color.AliceBlue;
            this.bGrabar.Location = new System.Drawing.Point(80, 15);
            this.bGrabar.Name = "bGrabar";
            this.bGrabar.Size = new System.Drawing.Size(75, 23);
            this.bGrabar.TabIndex = 2;
            this.bGrabar.Text = "GRABAR";
            this.bGrabar.UseVisualStyleBackColor = false;
            this.bGrabar.Click += new System.EventHandler(this.bGrabar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.bConsulta);
            this.panel2.Controls.Add(this.tbEspecialidad);
            this.panel2.Controls.Add(this.tbNombres);
            this.panel2.Controls.Add(this.tbApeMat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbApePate);
            this.panel2.Controls.Add(this.tbCodigoMedico);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 270);
            this.panel2.TabIndex = 9;
            // 
            // bConsulta
            // 
            this.bConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bConsulta.Location = new System.Drawing.Point(328, 183);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(66, 23);
            this.bConsulta.TabIndex = 5;
            this.bConsulta.Text = "CONSULTA";
            this.bConsulta.UseVisualStyleBackColor = false;
            this.bConsulta.Click += new System.EventHandler(this.bConsulta_Click);
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.BackColor = System.Drawing.Color.Snow;
            this.tbEspecialidad.Location = new System.Drawing.Point(184, 184);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(138, 20);
            this.tbEspecialidad.TabIndex = 13;
            // 
            // tbNombres
            // 
            this.tbNombres.BackColor = System.Drawing.Color.Snow;
            this.tbNombres.Location = new System.Drawing.Point(184, 137);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(138, 20);
            this.tbNombres.TabIndex = 9;
            // 
            // tbApeMat
            // 
            this.tbApeMat.BackColor = System.Drawing.Color.Snow;
            this.tbApeMat.Location = new System.Drawing.Point(184, 102);
            this.tbApeMat.Name = "tbApeMat";
            this.tbApeMat.Size = new System.Drawing.Size(138, 20);
            this.tbApeMat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ESPECIALIDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOMBRES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "APELLIDO MATERNO:";
            // 
            // tbApePate
            // 
            this.tbApePate.BackColor = System.Drawing.Color.Snow;
            this.tbApePate.Location = new System.Drawing.Point(184, 60);
            this.tbApePate.Name = "tbApePate";
            this.tbApePate.Size = new System.Drawing.Size(138, 20);
            this.tbApePate.TabIndex = 4;
            // 
            // tbCodigoMedico
            // 
            this.tbCodigoMedico.BackColor = System.Drawing.Color.Snow;
            this.tbCodigoMedico.Location = new System.Drawing.Point(184, 22);
            this.tbCodigoMedico.Name = "tbCodigoMedico";
            this.tbCodigoMedico.Size = new System.Drawing.Size(138, 20);
            this.tbCodigoMedico.TabIndex = 3;
            this.tbCodigoMedico.Leave += new System.EventHandler(this.tbCodigoMedico_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO PATERNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID MEDICO: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 51);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL MEDICO";
            // 
            // fmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmMedico";
            this.Text = "fmMedico";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bGrabar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bConsulta;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApeMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApePate;
        private System.Windows.Forms.TextBox tbCodigoMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}