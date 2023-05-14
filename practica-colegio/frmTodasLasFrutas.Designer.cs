namespace pry.COLEGIO.PracticaParcial
{
    partial class frmTodasLasFrutas
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
            this.FRUTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FRUTAS,
            this.Column2});
            this.dgvGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(232, 314);
            this.dgvGrilla.TabIndex = 1;
            // 
            // FRUTAS
            // 
            this.FRUTAS.HeaderText = "ID";
            this.FRUTAS.Name = "FRUTAS";
            this.FRUTAS.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FRUTAS";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // frmTodasLasFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 359);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "frmTodasLasFrutas";
            this.Text = "frmTodasLasFrutas";
            this.Load += new System.EventHandler(this.frmTodasLasFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRUTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}