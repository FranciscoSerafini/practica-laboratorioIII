using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry.COLEGIO.PracticaParcial
{
    public partial class FrmConsultarAlumnos : Form
    {
        public FrmConsultarAlumnos()
        {
            InitializeComponent();
        }
        Alumnos objAlumnos;
        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            objAlumnos = new Alumnos();
            objAlumnos.Documento = Convert.ToInt32(textBox1.Text);
            objAlumnos.Buscar();
            lblNombre.Text = objAlumnos.Nombre;
            
            lblSexo.Text = objAlumnos.Sexo;

            if (objAlumnos.Nombre == "")
            {
                pictureBox1.Image = null;
                MessageBox.Show("Alumno no encontrado");
            }
            else
            {
                pictureBox1.Load ("fotos/" + objAlumnos.Foto) ;
            }

        }

        private void FrmConsultarAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
