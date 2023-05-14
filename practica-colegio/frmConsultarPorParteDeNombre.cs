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
    public partial class frmConsultarPorParteDeNombre : Form
    {
        DataTable tabla;
        Alumnos objAlumnos;

        public frmConsultarPorParteDeNombre()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string busco = txtNombre.Text;
            string nombre = "";

            foreach (DataRow fila in tabla.Rows)
            {
                nombre = fila["nombre"].ToString();
                int posicion = nombre.IndexOf(busco);
                if (posicion >-1)
                {
                    dataGridView1.Rows.Add(fila["dni"].ToString(), fila["nombre"].ToString());

                }
            }
        }

        private void frmConsultarPorParteDeNombre_Load(object sender, EventArgs e)
        {
            objAlumnos = new Alumnos();
            tabla = objAlumnos.getAll();
        }
    }
}
