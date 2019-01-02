namespace AppControlClinica
{
    partial class fmEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEspecialidades));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buConsulta = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreEsp = new System.Windows.Forms.TextBox();
            this.tbCodEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGrabar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.buConsulta);
            this.panel2.Controls.Add(this.tbCost);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbNombreEsp);
            this.panel2.Controls.Add(this.tbCodEspecialidad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 216);
            this.panel2.TabIndex = 6;
            // 
            // buConsulta
            // 
            this.buConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buConsulta.Location = new System.Drawing.Point(303, 21);
            this.buConsulta.Name = "buConsulta";
            this.buConsulta.Size = new System.Drawing.Size(66, 23);
            this.buConsulta.TabIndex = 4;
            this.buConsulta.Text = "CONSULTA";
            this.buConsulta.UseVisualStyleBackColor = false;
            this.buConsulta.Click += new System.EventHandler(this.buConsulta_Click);
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.Color.Snow;
            this.tbCost.Location = new System.Drawing.Point(159, 102);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(138, 20);
            this.tbCost.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo: ";
            // 
            // tbNombreEsp
            // 
            this.tbNombreEsp.BackColor = System.Drawing.Color.Snow;
            this.tbNombreEsp.Location = new System.Drawing.Point(159, 60);
            this.tbNombreEsp.Name = "tbNombreEsp";
            this.tbNombreEsp.Size = new System.Drawing.Size(138, 20);
            this.tbNombreEsp.TabIndex = 4;
            // 
            // tbCodEspecialidad
            // 
            this.tbCodEspecialidad.BackColor = System.Drawing.Color.Snow;
            this.tbCodEspecialidad.Location = new System.Drawing.Point(159, 22);
            this.tbCodEspecialidad.Name = "tbCodEspecialidad";
            this.tbCodEspecialidad.Size = new System.Drawing.Size(138, 20);
            this.tbCodEspecialidad.TabIndex = 3;
            this.tbCodEspecialidad.Leave += new System.EventHandler(this.tbCodEspecialidad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Especialidad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Especialidad: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.bSalir);
            this.panel3.Controls.Add(this.bGrabar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 50);
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
            // fmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 216);
            this.Controls.Add(this.panel2);
            this.Name = "fmEspecialidades";
            this.Text = "fmEspecialidades";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buConsulta;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreEsp;
        private System.Windows.Forms.TextBox tbCodEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bGrabar;
    }
}