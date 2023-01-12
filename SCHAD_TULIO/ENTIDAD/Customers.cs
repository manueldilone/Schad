using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO.ENTIDAD
{
    internal class Customers
    {

        public int CustomersId { get; set; }
    public string CustName    { get; set; }
        public Boolean Status { get; set; }
public string Adress  { get; set; }

        public List<CustomerTypes> CustomerTypes { get; set; }


        public DataTable ObtenerTodosCustomer()
        {

            BDComun d = new BDComun();

            return d.DatosTabla("SELECT * FROM " + VariablesGlobales.DBPRINCIPAL + ".Customers");
        }


        public void InsertQuery(string CustName, string Adress, int Status, int CustomerTypeId)
        {
            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".Customers(CustName, Adress, Status,CustomerTypeId) values('" + CustName + "','" + Adress + "'," + Status + "," + CustomerTypeId + ")";
            d.ActualizarTabla(strSQL);

        }
        public void UpdateQuery(int Id, string CustName, string Adress, int Status, int CustomerTypeId)
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".Customers set CustName='" + CustName + "',Adress='" + Adress + "', Status=" + Status + ", CustomerTypeId= " + CustomerTypeId + " where Id=" + Id + "";
            d.ActualizarTabla(strSQL);

        }

        public void DeleteQuery(int Id)
        {
            BDComun d = new BDComun();
            String strSQL = "delete from " + VariablesGlobales.DBPRINCIPAL + ".Customers where Id=" + Id + "";
            d.ActualizarTabla(strSQL);

        }


        public int obteneridsiguiente()
        {

            using (SqlConnection conexion = BDComun.Siif())
            {
                string query = string.Format("SELECT Count(Id) + 1 AS ultimo from " + VariablesGlobales.DBPRINCIPAL + ".Customers where exists (select Id, COUNT(Id) total from " + VariablesGlobales.DBPRINCIPAL + ".Customers GROUP BY Id)");
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    settCodigo(reader.GetInt32(0));

                }
                return getCodigo();
            }
        }
        public int getCodigo() { return CustomersId; }
        public void settCodigo(int valor) { CustomersId = valor; }


    }
}
