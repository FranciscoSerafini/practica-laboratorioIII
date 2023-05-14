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
    public partial class FrmFrutasQueLeGustanAunAlumno : Form
    {
        public FrmFrutasQueLeGustanAunAlumno()
        {
            InitializeComponent();
        }
        Alumnos objAlumnos;
        clsFrutasAlumnos objFrutasAlumnos;
        private void FrmFrutasQueLeGustanAunAlumno_Load(object sender, EventArgs e)
        {
            objAlumnos = new Alumnos();
           cbAlumno .DisplayMember = "nombre";
            cbAlumno.ValueMember = "dni";
            cbAlumno.DataSource = objAlumnos.getAll();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            objFrutasAlumnos = new clsFrutasAlumnos();
            int dni = Convert.ToInt32(cbAlumno.SelectedValue);
            objFrutasAlumnos.MostrarGrilla(dgvFruta, dni);
        }
    }
}
