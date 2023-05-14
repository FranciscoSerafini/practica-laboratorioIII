namespace pry.COLEGIO.PracticaParcial
{
    partial class frmFrutasGustanAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lstFrutas = new System.Windows.Forms.ComboBox();
            this.cmbDNI = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DNI Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la Fruta que le gusta:";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(47, 89);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(136, 23);
            this.cmdRegistrar.TabIndex = 2;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Location = new System.Drawing.Point(181, 50);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(87, 21);
            this.lstFrutas.TabIndex = 4;
            // 
            // cmbDNI
            // 
            this.cmbDNI.FormattingEnabled = true;
            this.cmbDNI.Location = new System.Drawing.Point(123, 6);
            this.cmbDNI.Name = "cmbDNI";
            this.cmbDNI.Size = new System.Drawing.Size(145, 21);
            this.cmbDNI.TabIndex = 5;
            // 
            // frmFrutasGustanAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 135);
            this.Controls.Add(this.cmbDNI);
            this.Controls.Add(this.lstFrutas);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFrutasGustanAlumnos";
            this.Text = "frmFrutasGustanAlumnos";
            this.Load += new System.EventHandler(this.frmFrutasGustanAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.ComboBox lstFrutas;
        private System.Windows.Forms.ComboBox cmbDNI;
    }
}