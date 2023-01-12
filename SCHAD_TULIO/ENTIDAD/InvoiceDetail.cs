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
  
            return d.DatosTabla("SELECT a.*,(select d.CustomerId from " + VariablesGlobales.DBPRINCIPAL + ".Invoice d where d.id=a.CustomerId) as CodCliente FROM " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail a");
        }



        public void InsertQuery(int Id, int CustomerId, int Qty, double Price,double TotalItbis, double Subtotal,double Total )
        {
            Invoice invoice= new Invoice();
            invoice.CustomersId = CustomerId;

            invoice.TotalItebis = TotalItbis;
            invoice.Subtotal = Subtotal;
            invoice.Total = Total;


            invoice.guardar();

            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail(CustomerId,Qty, Price,TotalItbis, Subtotal,Total) values("+ Id + "," + Qty+", '" + Price + "','" + TotalItbis+"', '" + Subtotal + "','" + Total+"')";
            d.ActualizarTabla(strSQL);

            
        }
        public void UpdateQuery(int Id, int CustomerId, int Qty, double Price, double TotalItbis, double Subtotal, double Total)
        {
            BDComun d = new BDComun();
            Invoice invoice = new Invoice();
            invoice.CustomersId = CustomerId;

            invoice.TotalItebis = TotalItbis;
            invoice.Subtotal = Subtotal;
            invoice.Total = Total;
            invoice.InvoicId = Id;
            invoice.modificar();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".InvoiceDetail set CustomerId="+ CustomerId + ", Qty="+ Qty + ", Price="+ Price + ",TotalItbis="+ TotalItbis + ", Subtotal="+ Subtotal + ",Total="+ Total + " where Id=" + Id + "";
            d.ActualizarTabla(strSQL);
          

        }


     


      


    }


}
