using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO.ENTIDAD
{
    internal class Invoice : InvoiceDetail
    {
       // public int InvoiceIds { get; set; }
        public int InvoicId { get; set; }
        public double TotalItebis { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }

        //public DataTable ObtenerTodosRegistro()
        //{

        //    BDComun d = new BDComun();

        //    return d.DatosTabla("SELECT * FROM " + VariablesGlobales.DBPRINCIPAL + ".Invoice");
        //}









        public void guardar()
        {
            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".Invoice(CustomerId, TotalItbis, Subtotal,Total) values(" + this.CustomersId + "," + this.TotalItebis + ", " + this.Subtotal + "," + this.Total + ")";


            d.ActualizarTabla(strSQL);


        }
        public void modificar()
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".Invoice set CustomerId=" + this.CustomersId + ", TotalItbis=" + this.TotalItebis + ", Subtotal=" + this.Subtotal + ",Total=" + this.Total + "  where Id=" + this.InvoicId + "";
            d.ActualizarTabla(strSQL);


        }

        public int obteneridsiguiente()
        {
            decimal vlor;
            using (SqlConnection conexion = BDComun.Siif())
            {
                string query = string.Format("SELECT IDENT_CURRENT('" + VariablesGlobales.DBPRINCIPAL + ".Invoice') ");
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    InvoicId = Convert.ToInt32(reader.GetDecimal(0))+1;

                }
                return InvoicId;
            }
        }

    
    }

}
