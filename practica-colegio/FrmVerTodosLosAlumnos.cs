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
    public partial class FrmVerTodosLosAlumnos : Form
    {
        Alumnos objAlumnos;
        public FrmVerTodosLosAlumnos()
        {
            InitializeComponent();
        }

        private void FrmVerTodosLosAlumnos_Load(object sender, EventArgs e)
        {
            objAlumnos = new Alumnos();
            objAlumnos.VerGrilla(dataGridView1);
        }
    }
}
