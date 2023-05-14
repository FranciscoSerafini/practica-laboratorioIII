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
    public partial class frmAqueAlumnoLeGustaUnaFruta : Form
    {
        clsFruta objFruta;
        clsFrutasAlumnos objFrutaAlumnos;
        public frmAqueAlumnoLeGustaUnaFruta()
        {
            InitializeComponent();
        }

        private void frmAqueAlumnoLeGustaUnaFruta_Load(object sender, EventArgs e)
        {
            objFruta = new clsFruta();

            lstFrutas.DisplayMember = "nombre";
            lstFrutas.SelectedValue = "fruta";
            lstFrutas.DataSource = objFruta.getAll();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objFrutaAlumnos = new clsFrutasAlumnos();
            
            Int32 fruta = Convert.ToInt32(lstFrutas.SelectedValue);
            objFrutaAlumnos.MostrarAlumno(dgvGrilla, fruta);
            
        }
    }
}
