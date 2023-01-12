using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO.ENTIDAD
{
    internal class Invoice: InvoiceDetail
    {
        public int InvoiceId { get; set; }

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
        String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".Invoice(Id, CustomerId, TotalItbis, Subtotal,Total) values("+ this.InvoiceId + "," + this.CustomersId + "," + this.TotalItebis + ", " + this.Subtotal + "," + this.Total + ")";
      
            
        d.ActualizarTabla(strSQL);


    }
        public void modificar()
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".Invoice set CustomerId="+this.CustomersId+ ", TotalItbis="+this.TotalItebis+ ", Subtotal="+this.Subtotal+",Total="+this.Total+"  where Id="+ this.InvoiceId + "";
            d.ActualizarTabla(strSQL);


        }

    }

}
