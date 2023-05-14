namespace pry.COLEGIO.PracticaParcial
{
    partial class FrmFrutasQueLeGustanAunAlumno
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
            this.FRUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFruta
            // 
            this.dgvFruta.AllowUserToAddRows = false;
            this.dgvFruta.AllowUserToDeleteRows = false;
            this.dgvFruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FRUTA});
            this.dgvFruta.Location = new System.Drawing.Point(12, 87);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.ReadOnly = true;
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(499, 300);
            this.dgvFruta.TabIndex = 8;
            // 
            // FRUTA
            // 
            this.FRUTA.HeaderText = "FRUTA";
            this.FRUTA.MinimumWidth = 6;
            this.FRUTA.Name = "FRUTA";
            this.FRUTA.ReadOnly = true;
            // 
            // cbAlumno
            // 
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(93, 20);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(247, 21);
            this.cbAlumno.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(362, 14);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(149, 41);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "VER";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmFrutasQueLeGustanAunAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 394);
            this.Controls.Add(this.dgvFruta);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmFrutasQueLeGustanAunAlumno";
            this.Text = "FrmFrutasQueLeGustanAunAlumno";
            this.Load += new System.EventHandler(this.FrmFrutasQueLeGustanAunAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRUTA;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblNombre;
    }
}