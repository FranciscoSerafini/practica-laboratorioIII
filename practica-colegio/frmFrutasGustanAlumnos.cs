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
    
    public partial class frmFrutasGustanAlumnos : Form
    {
        public frmFrutasGustanAlumnos()
        {
            InitializeComponent();
        }
        
        clsFruta objFruta;
        Alumnos alumnos;
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            clsFrutasAlumnos objFrutasAlumnos = new clsFrutasAlumnos();
            objFrutasAlumnos = new clsFrutasAlumnos();
            objFrutasAlumnos.dni = Convert.ToInt32(cmbDNI.SelectedValue);
            objFrutasAlumnos.fruta = Convert.ToInt32(lstFrutas.SelectedValue);
            objFrutasAlumnos.Registrar();
            MessageBox.Show("Dato guardado con exito");

        }

        private void frmFrutasGustanAlumnos_Load(object sender, EventArgs e)
        {
            objFruta = new clsFruta();
            lstFrutas.DisplayMember = "nombre";
            lstFrutas.ValueMember = "fruta";
            lstFrutas.DataSource = objFruta.getAll();

            alumnos = new Alumnos();
            cmbDNI.DisplayMember = "nombre";
            cmbDNI.ValueMember = "dni";
            cmbDNI.DataSource = alumnos.getAll();
        }
    }
}
