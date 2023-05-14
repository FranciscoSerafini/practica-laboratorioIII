using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Claims;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace pry.COLEGIO.PracticaParcial
{
    internal class clsFruta
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private string cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private DataSet Ds = new DataSet();

        private string NombreFruta;
        private Int32 IdFruta;

        public string Nombre 
        {
          get { return NombreFruta; }
           set { NombreFruta = value; }
        }
        public Int32 ID 
        {
            get { return IdFruta; }
            set { IdFruta = value; }
        }

        public clsFruta()
        {
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["fruta"];
            tabla.PrimaryKey = dc;
        }
        public void grabar()
        {
            DataTable dt = Ds.Tables["Frutas"];
            DataRow buscarFila = tabla.Rows.Find(IdFruta);
            

            if (buscarFila is null)
            {
                DataRow fila = tabla.NewRow();
                fila["nombre"] = NombreFruta;
                fila["fruta"] = IdFruta;
                
                tabla.Rows.Add(fila);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);

            }
            else
            {
                NombreFruta = "";
                IdFruta= 0;
               
            }
        }
        public DataTable getAll()
        {
            return tabla;
        }
        public string buscar(int fruta)
        {
            DataRow fila = tabla.Rows.Find(fruta);
            return fila["nombre"].ToString();
        }

        public void VerFrutas(DataGridView grilla)
        {
            grilla.Rows.Clear();
            foreach(DataRow fila in tabla.Rows)
            {
                grilla.Rows.Add(fila["fruta"], fila["nombre"]);
            }
        }
        
    }
}
