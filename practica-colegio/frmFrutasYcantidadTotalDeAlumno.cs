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
    public partial class frmFrutasYcantidadTotalDeAlumno : Form
    {
        clsFrutasAlumnos objFrutasALumnos;
        clsFruta objFruta;
        public frmFrutasYcantidadTotalDeAlumno()
        {
            InitializeComponent();
        }

        private void frmFrutasYcantidadTotalDeAlumno_Load(object sender, EventArgs e)
        {
            objFrutasALumnos = new clsFrutasAlumnos();
            objFruta = new clsFruta();

            cbFruta.DisplayMember = "nombre";
            cbFruta.ValueMember = "fruta";
            cbFruta.DataSource = objFruta.getAll();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int fruta = Convert.ToInt32(cbFruta.SelectedValue);
            objFrutasALumnos.sumar(dgvFruta, fruta);
        }
    }
}
