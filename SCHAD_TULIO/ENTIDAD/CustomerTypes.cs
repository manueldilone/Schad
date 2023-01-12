using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql ;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace SCHAD_TULIO.ENTIDAD
{

    public class CustomerTypes
    {
       
        public int Id { get; set; }

        public string Description { get; set; }





        public DataTable ObtenerCustomerTypes(int Id)
        {

            BDComun d = new BDComun();
            //return d.DatosTabla (
            return d.DatosTabla("SELECT Id, Description FROM " + VariablesGlobales.DBPRINCIPAL  + ".CustomerTypes where Id=" + Id);
        }

        public DataTable ObtenertodosCustomerTypes()
        {

            BDComun d = new BDComun();
            //return d.DatosTabla (
            return d.DatosTabla("SELECT Id, Description FROM " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes");
        }

        public int obteneridsiguiente()
        {

            using (SqlConnection conexion = BDComun.Siif())
            {
                string query = string.Format("SELECT Count(Id) + 1 AS ultimo from " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes where exists (select Id, COUNT(Id) total from " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes GROUP BY Id)");
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    settCodigo(reader.GetInt32(0));

                }
                return getCodigo();
            }
        }
        public int getCodigo() { return Id; }
        public void settCodigo(int valor) { Id = valor; }



        public void InsertQuery(string Description)
        {
            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes(Description) values('" + Description + "')";
            d.ActualizarTabla(strSQL);

        }
        public void UpdateQuery(int Id, string Description)
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes set Description='" + Description + "' where Id=" + Id + "";
            d.ActualizarTabla(strSQL);

        }

        public void DeleteQuery(int Id)
        {
            BDComun d = new BDComun();
            String strSQL = "delete from " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes where Id=" + Id + "";
            d.ActualizarTabla(strSQL);

        }

        public int getCodId(String Description)
        {

            BDComun d = new BDComun();

            string query = "SELECT Id FROM " + VariablesGlobales.DBPRINCIPAL +  ".CustomerTypes where Description='" + Description + "'";
            DataRow drSQL = d.RegistroTabla(query);


            return Int32.Parse(drSQL["Id"].ToString()); ;
        }

        public string getDescription(int Id)
        {

            BDComun d = new BDComun();

            string query = "SELECT Description FROM " + VariablesGlobales.DBPRINCIPAL + ".CustomerTypes where Id='" + Id + "'";
            DataRow drSQL = d.RegistroTabla(query);


            return drSQL["Description"].ToString(); 
        }

    }
}