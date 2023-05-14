using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.COLEGIO.PracticaParcial
{
    
    internal class clsFrutasAlumnos
    {
       //declaramos los objetos
        clsFruta objFruta = new clsFruta();
        Alumnos objAlumno;
        //declaramos los comandos para la base
        private OleDbConnection conector;
        private OleDbCommand comando;
        private string cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private DataSet Ds = new DataSet();

        private Int32 DNI;
        private Int32 FRUTA;

        public Int32 dni 
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public Int32 fruta
        {
            get { return FRUTA; }
            set { FRUTA = value; }
        }
        public clsFrutasAlumnos()
        {
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "LeGustan";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

           


        }
        public void Registrar()
        {

            DataRow fila = tabla.NewRow();
            fila["dni"] = dni;
            fila["fruta"] = fruta;
            tabla.Rows.Add(fila);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);

        }
        public DataTable getAll()
        {
            return tabla;
        }
        
        public void MostrarGrilla(DataGridView grilla, int busco) 
        {
            grilla.Rows.Clear();
            foreach(DataRow fila in tabla.Rows)
            {
                if (busco == Convert.ToInt32(fila["dni"]))
                {
                    string fruta = objFruta.buscar(Convert.ToInt32(fila["fruta"]));
                    grilla.Rows.Add(fruta);
                }
            }
        
        }

        public void MostrarAlumno(DataGridView grilla, Int32 buscar)
        {
            grilla.Rows.Clear();
            objAlumno = new Alumnos();

            foreach (DataRow fila in tabla.Rows)
            {
                if (buscar == Convert.ToInt32(fila["fruta"]))
                {
                    string alumno = objAlumno.BuscarAlumno(Convert.ToInt32(fila["dni"]));
                    grilla.Rows.Add(alumno);
                }
            }
        }
        public void VerFrutasNo(DataGridView grilla, int busco)
        {
            grilla.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                if (busco == Convert.ToInt32(fila["dni"]));
                {
                    string fruta = objFruta.buscar(Convert.ToInt32(fila["fruta"]));
                    grilla.Rows.Add(fruta);
                }
            }
        }
        public void sumar(DataGridView grilla, int fruta)
        {
            int indice = 0;
            grilla.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                if (fruta == Convert.ToInt32(fila["fruta"]))
                {
                    indice++;
                }
            }
            string f = objFruta.buscar(Convert.ToInt32(fruta));
            grilla.Rows.Add(f, indice);
        }


    }

}
