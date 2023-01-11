using SCHAD_TULIO.ClasesComunicativas;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SCHAD_TULIO.ENTIDAD
{
     class tblmnu_usuarios
    {
        private String pNombre;
        private String pUsuario;
        private String pPassword;
        private DateTime pVencimiento;
        private int pActivo;
        private int pNoVence;
        private int pCodDpto;
        private int pcant;



        private String Nombre { get { return pNombre; } set { pNombre = value; } }
        private String Usuario { get { return pUsuario; } set { pUsuario = value; } }
        private String Password { get { return pPassword; } set { pPassword = value; } }
        private DateTime Vencimiento { get { return pVencimiento; } set { pVencimiento = value; } }
        private int Activo { get { return pActivo; } set { pActivo = value; } }
        private int NoVence { get { return pNoVence; } set { pNoVence = value; } }
        private int CodDpto { get { return pCodDpto; } set { pCodDpto = value; } }

        public int cant { get { return pcant; } set { pcant = value; } }


        public bool ExisteReg(String usuario)
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("select count(*) as cantreg FROM tblmnu_usuarios where Usuario='" + usuario + "'");

            if (Int32.Parse(drSQL["cantreg"].ToString()) > 0)
            {
                pcant = Int32.Parse(drSQL["cantreg"].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool equals(String usuario, String password)
        {

            BDComun d = new BDComun();


            DataRow drSQL = d.RegistroTabla("select count(*) as cantreg FROM " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios where Activo=1 and Usuario='" + usuario + "' and Password='" + password + "'");

            if (Int32.Parse(drSQL["cantreg"].ToString()) > 0)
            {



                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ObtenerTodos()
        {

            BDComun d = new BDComun();
            return d.DatosTabla("SELECT CodUser,Nombre,Usuario,Password,Activo,NoVence FROM " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios");

        }

        public string GetSiguiente()
        {
            string repuesta = "";
            SqlConnection cnn = BDComun.Siif();

            string cadena;
            cadena = "SELECT MAX(CodUser) + 1 AS ultimo from " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios where exists (select CodUser, COUNT(CodUser) total from " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios GROUP BY CodUser)";
            SqlCommand cmd = new SqlCommand(cadena, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                repuesta = (string)Convert.ToInt32(reader[0]).ToString();
            }

            return repuesta;
        }
        public void Agregar(int CodUser, string Nombre, string Usuario, string Password, int Activo, int NoVence)
        {
            BDComun d = new BDComun();
            String strSQL = "insert into " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios(CodUser,Nombre,Usuario,Password,Activo,NoVence) values(" + CodUser + ",'" + Nombre + "','" + Usuario + "','" + Password + "'," + Activo + "," + NoVence + ")";
            d.ActualizarTabla(strSQL);

        }
        public void Modificar(int CodUser, string Password, int Activo, int NoVence)
        {
            BDComun d = new BDComun();
            String strSQL = "update " + VariablesGlobales.DBPRINCIPAL + ".tblmnu_usuarios set Password='" + Password + "' , Activo=" + Activo + ",NoVence=" + NoVence + " where CodUser=" + CodUser + "";
            d.ActualizarTabla(strSQL);

        }
    }
}

