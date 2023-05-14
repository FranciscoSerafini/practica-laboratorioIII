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
    public partial class frmQueFrutasNoLegustanAunalumno : Form
    {
        Alumnos objAlumno;
        clsFrutasAlumnos objFrutasAlumnos;
        public frmQueFrutasNoLegustanAunalumno()
        {
            InitializeComponent();
        }

        private void frmQueFrutasNoLegustanAunalumno_Load(object sender, EventArgs e)
        {
            objAlumno = new Alumnos();

            cbNombre.DisplayMember = "nombre";
            cbNombre.ValueMember = "dni";
            cbNombre.DataSource = objAlumno.getAll();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            objFrutasAlumnos = new clsFrutasAlumnos();
            int dni = Convert.ToInt32(cbNombre.SelectedValue);
            objFrutasAlumnos.VerFrutasNo(dgvFruta, dni);
        }
    }
}
