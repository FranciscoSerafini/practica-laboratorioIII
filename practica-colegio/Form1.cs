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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarAlumnos frmRegistrarAlumnos = new frmRegistrarAlumnos();    
            frmRegistrarAlumnos.ShowDialog();
        }

        private void aQueAlumnosLeGustaUnaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFrutasQueLeGustanAunAlumno objVentana = new FrmFrutasQueLeGustanAunAlumno();
            objVentana.ShowDialog();
        }

        private void verTodasLasFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTodasLasFrutas objVentana = new frmTodasLasFrutas();
            objVentana.ShowDialog();
        }

        private void consultarAlumnosPorParteDeSuNombewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPorParteDeNombre objVentana = new frmConsultarPorParteDeNombre();
            objVentana.ShowDialog();
        }

        private void nuevoBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarBarrio frmAgregarBarrio = new frmAgregarBarrio(); 
            frmAgregarBarrio.ShowDialog();
        }

        private void nuevaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarFrutas frmAgregarFrutas = new frmAgregarFrutas();
            frmAgregarFrutas.ShowDialog();
        }

        private void queFrutasLeGustaAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasGustanAlumnos frmFrutas = new frmFrutasGustanAlumnos();
            frmFrutas.ShowDialog();
        }

        private void consultarAlumnoPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAlumnos objVentana = new FrmConsultarAlumnos();
            objVentana.ShowDialog();
        }

        private void consultarQueFrutasLeGustanAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFrutasQueLeGustanAunAlumno objVentana = new FrmFrutasQueLeGustanAunAlumno();
            
            objVentana.ShowDialog();
        }

        private void verTodosLosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerTodosLosAlumnos objVentana = new FrmVerTodosLosAlumnos();
            objVentana.ShowDialog();
        }

        private void queFrutasNoLeGustaAUnAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueFrutasNoLegustanAunalumno objVentana = new frmQueFrutasNoLegustanAunalumno();
            objVentana.ShowDialog();
        }

        private void cantidadTotalDeAlumnosPorFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasYcantidadTotalDeAlumno objVentana = new frmFrutasYcantidadTotalDeAlumno();
            objVentana.ShowDialog();
        }
    }
}
