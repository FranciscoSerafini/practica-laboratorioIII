namespace pry.COLEGIO.PracticaParcial
{
    partial class frmAqueAlumnoLeGustaUnaFruta
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.ALUMNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFrutas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ALUMNO});
            this.dgvGrilla.Location = new System.Drawing.Point(12, 33);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(344, 234);
            this.dgvGrilla.TabIndex = 7;
            // 
            // ALUMNO
            // 
            this.ALUMNO.HeaderText = "ALUMNO";
            this.ALUMNO.Name = "ALUMNO";
            this.ALUMNO.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una Fruta:";
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Location = new System.Drawing.Point(126, 6);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(134, 21);
            this.lstFrutas.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(281, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAqueAlumnoLeGustaUnaFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 301);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFrutas);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmAqueAlumnoLeGustaUnaFruta";
            this.Text = "frmAqueAlumnoLeGustaUnaFruta";
            this.Load += new System.EventHandler(this.frmAqueAlumnoLeGustaUnaFruta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALUMNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstFrutas;
        private System.Windows.Forms.Button btnBuscar;
    }
}