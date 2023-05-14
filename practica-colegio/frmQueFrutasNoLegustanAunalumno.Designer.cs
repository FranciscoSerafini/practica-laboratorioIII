namespace pry.COLEGIO.PracticaParcial
{
    partial class frmQueFrutasNoLegustanAunalumno
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
            this.dgvFruta = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruta
            // 
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFruta.Location = new System.Drawing.Point(12, 69);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(466, 309);
            this.dgvFruta.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(332, 41);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 21);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(62, 42);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(264, 21);
            this.cbNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FRUTAS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmQueFrutasNoLegustanAunalumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.dgvFruta);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmQueFrutasNoLegustanAunalumno";
            this.Text = "frmQueFrutasNoLegustanAunalumno";
            this.Load += new System.EventHandler(this.frmQueFrutasNoLegustanAunalumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}