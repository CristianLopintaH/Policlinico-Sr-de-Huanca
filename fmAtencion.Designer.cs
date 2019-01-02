namespace AppControlClinica
{
    partial class fmAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAtencion));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGrabar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdMedico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTratamiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiagnostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroRecibo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 50);
            this.panel3.TabIndex = 0;
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.bSalir.Location = new System.Drawing.Point(320, 15);
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
            this.bGrabar.Location = new System.Drawing.Point(42, 15);
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
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tbIdMedico);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbTratamiento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbDiagnostico);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbNroRecibo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 302);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 50);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 45);
            this.label7.TabIndex = 2;
            this.label7.Text = "FICHA DE ATENCION";
            // 
            // tbIdMedico
            // 
            this.tbIdMedico.BackColor = System.Drawing.Color.Snow;
            this.tbIdMedico.Location = new System.Drawing.Point(186, 109);
            this.tbIdMedico.Name = "tbIdMedico";
            this.tbIdMedico.Size = new System.Drawing.Size(138, 20);
            this.tbIdMedico.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(39, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID. MEDICO: ";
            // 
            // tbTratamiento
            // 
            this.tbTratamiento.BackColor = System.Drawing.Color.Snow;
            this.tbTratamiento.Location = new System.Drawing.Point(186, 195);
            this.tbTratamiento.Name = "tbTratamiento";
            this.tbTratamiento.Size = new System.Drawing.Size(138, 20);
            this.tbTratamiento.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TRATAMIENTO:";
            // 
            // tbDiagnostico
            // 
            this.tbDiagnostico.BackColor = System.Drawing.Color.Snow;
            this.tbDiagnostico.Location = new System.Drawing.Point(186, 152);
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Size = new System.Drawing.Size(138, 20);
            this.tbDiagnostico.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(39, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DIAGNOSTICO: ";
            // 
            // tbNroRecibo
            // 
            this.tbNroRecibo.BackColor = System.Drawing.Color.Snow;
            this.tbNroRecibo.Location = new System.Drawing.Point(186, 68);
            this.tbNroRecibo.Name = "tbNroRecibo";
            this.tbNroRecibo.Size = new System.Drawing.Size(138, 20);
            this.tbNroRecibo.TabIndex = 3;
            this.tbNroRecibo.Leave += new System.EventHandler(this.tbNroRecibo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. RECIBO: ";
            // 
            // fmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.panel2);
            this.Name = "fmAtencion";
            this.Text = "fmAtenncion";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdMedico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTratamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroRecibo;
        private System.Windows.Forms.Label label2;
    }
}