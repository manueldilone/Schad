using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO.ENTIDAD
{
    internal class InvoiceDetail: Customers
    {
        public int id { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }


        public DataTable ObtenerTodosRegistro()
        {

            BDComun d = new BDComun();
  
            return d.DatosTabla("SELECT * FROM " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail");
        }



        public void InsertQuery(int InvoiceId, int CustomerId, int Qty, double Price,double TotalItbis, double Subtotal,double Total )
        {
            Invoice invoice= new Invoice();
            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail(Id,CustomerId,Qty, Price,TotalItbis, Subtotal,Total) values("+ InvoiceId + ","+CustomerId + "," + Qty+", " + Price + "," + TotalItbis+", " + Subtotal + "," + Total+")";
            d.ActualizarTabla(strSQL);

            invoice.CustomersId=CustomerId;
        
            invoice.TotalItebis = TotalItbis;
            invoice.Subtotal = Subtotal;
            invoice.Total = Total;
            invoice.InvoiceId = InvoiceId;
            invoice.guardar();

        }
        public void UpdateQuery(int InvoiceId, int Id, int CustomerId, int Qty, double Price, double TotalItbis, double Subtotal, double Total)
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail set CustomerId="+ CustomerId + ", Qty="+ Qty + ", Price="+ Price + ",TotalItbis="+ TotalItbis + ", Subtotal="+ Subtotal + ",Total="+ Total + " where Id=" + Id + "";
            d.ActualizarTabla(strSQL);
            Invoice invoice = new Invoice();
            invoice.CustomersId = CustomerId;

            invoice.TotalItebis = TotalItbis;
            invoice.Subtotal = Subtotal;
            invoice.Total = Total;
            invoice.InvoiceId = InvoiceId;
            invoice.modificar();

        }


        public int getCodigo() { return id; }
        public void settCodigo(int valor) { id = valor; }


        public int obteneridsiguiente()
        {

            using (SqlConnection conexion = BDComun.Siif())
            {
                string query = string.Format("SELECT Count(Id) + 1 AS ultimo from " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail where exists (select Id, COUNT(Id) total from " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail GROUP BY Id)");
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    settCodigo(reader.GetInt32(0));

                }
                return getCodigo();
            }
        }


    }


}
