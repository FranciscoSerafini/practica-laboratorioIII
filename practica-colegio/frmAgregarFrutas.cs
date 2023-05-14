using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.COLEGIO.PracticaParcial
{
    public partial class frmAgregarFrutas : Form
    {
        clsFruta objFruta;
        public frmAgregarFrutas()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objFruta = new clsFruta();
                objFruta.Nombre = txtFruta.Text;
                objFruta.ID = Convert.ToInt32(txtIdFruta.Text);
                objFruta.grabar();

                if (objFruta.ID == 0)
                {
                    MessageBox.Show("la fruta esta registrada", "Error");
                }
                else
                {
                    txtFruta.Text = "";
                    txtIdFruta.Text = "";
                    txtFruta.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Tu fruta se repite");
            }
        }
    }
}
