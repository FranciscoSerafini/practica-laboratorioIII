namespace pry.COLEGIO.PracticaParcial
{
    partial class frmAgregarFrutas
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
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtFruta = new System.Windows.Forms.TextBox();
            this.txtIdFruta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Fruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id de Fruta:";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(54, 111);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(132, 23);
            this.cmdAgregar.TabIndex = 2;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtFruta
            // 
            this.txtFruta.Location = new System.Drawing.Point(108, 21);
            this.txtFruta.Name = "txtFruta";
            this.txtFruta.Size = new System.Drawing.Size(100, 20);
            this.txtFruta.TabIndex = 3;
            // 
            // txtIdFruta
            // 
            this.txtIdFruta.Location = new System.Drawing.Point(108, 63);
            this.txtIdFruta.Name = "txtIdFruta";
            this.txtIdFruta.Size = new System.Drawing.Size(100, 20);
            this.txtIdFruta.TabIndex = 4;
            // 
            // frmAgregarFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 152);
            this.Controls.Add(this.txtIdFruta);
            this.Controls.Add(this.txtFruta);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarFrutas";
            this.Text = "frmAgregarFrutas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtFruta;
        private System.Windows.Forms.TextBox txtIdFruta;
    }
}