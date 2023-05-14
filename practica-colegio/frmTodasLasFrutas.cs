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
    public partial class frmTodasLasFrutas : Form
    {
        clsFruta objFruta;
        public frmTodasLasFrutas()
        {
            InitializeComponent();
        }

        private void frmTodasLasFrutas_Load(object sender, EventArgs e)
        {
            objFruta = new clsFruta();
            objFruta.VerFrutas(dgvGrilla);
        }
    }
}
