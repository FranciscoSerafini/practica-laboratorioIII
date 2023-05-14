namespace pry.COLEGIO.PracticaParcial
{
    partial class frmFrutasYcantidadTotalDeAlumno
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
            this.btnVer = new System.Windows.Forms.Button();
            this.lblFruta = new System.Windows.Forms.Label();
            this.cbFruta = new System.Windows.Forms.ComboBox();
            this.dgvFruta = new System.Windows.Forms.DataGridView();
            this.FRUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(364, 12);
            this.btnVer.Margin = new System.Windows.Forms.Padding(2);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(94, 27);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruta.Location = new System.Drawing.Point(21, 17);
            this.lblFruta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(42, 18);
            this.lblFruta.TabIndex = 6;
            this.lblFruta.Text = "Fruta";
            // 
            // cbFruta
            // 
            this.cbFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFruta.FormattingEnabled = true;
            this.cbFruta.Location = new System.Drawing.Point(93, 12);
            this.cbFruta.Margin = new System.Windows.Forms.Padding(2);
            this.cbFruta.Name = "cbFruta";
            this.cbFruta.Size = new System.Drawing.Size(256, 25);
            this.cbFruta.TabIndex = 5;
            // 
            // dgvFruta
            // 
            this.dgvFruta.AllowUserToAddRows = false;
            this.dgvFruta.AllowUserToDeleteRows = false;
            this.dgvFruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FRUTA,
            this.CANTIDAD});
            this.dgvFruta.Location = new System.Drawing.Point(11, 61);
            this.dgvFruta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFruta.Name = "dgvFruta";
            this.dgvFruta.ReadOnly = true;
            this.dgvFruta.RowHeadersWidth = 51;
            this.dgvFruta.RowTemplate.Height = 24;
            this.dgvFruta.Size = new System.Drawing.Size(478, 309);
            this.dgvFruta.TabIndex = 4;
            // 
            // FRUTA
            // 
            this.FRUTA.HeaderText = "FRUTA";
            this.FRUTA.MinimumWidth = 6;
            this.FRUTA.Name = "FRUTA";
            this.FRUTA.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // frmFrutasYcantidadTotalDeAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.cbFruta);
            this.Controls.Add(this.dgvFruta);
            this.Name = "frmFrutasYcantidadTotalDeAlumno";
            this.Text = "frmFrutasYcantidadTotalDeAlumno";
            this.Load += new System.EventHandler(this.frmFrutasYcantidadTotalDeAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFruta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.ComboBox cbFruta;
        private System.Windows.Forms.DataGridView dgvFruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRUTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    }
}