using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO
{
    public class Usuarios
    {
        private String pusuario;
        private String pclave;
        private DateTime pfecha1;
        private String phora1;
        private DateTime pfecha2;
        private String phora2;
        private String pcondicion;
        private String pperfil;

        public String perfil
        {
            get
            {
                return pperfil;
            }
            set
            {
                pperfil = value;
            }
        }
        public String condicion
        {
            get
            {
                return pcondicion;
            }
            set
            {
                pcondicion = value;
            }
        }
        public String hora2
        {
            get
            {
                return phora2;
            }
            set
            {
                phora2 = value;
            }
        }
        public DateTime fecha2
        {
            get
            {
                return pfecha2;
            }
            set
            {
                pfecha2 = value;
            }
        }
        public String hora1
        {
            get
            {
                return phora1;
            }
            set
            {
                phora1 = value;
            }
        }
        public DateTime fecha1
        {
            get
            {
                return pfecha1;
            }
            set
            {
                pfecha1 = value;
            }
        }
        public String clave
        {
            get
            {
                return pclave;
            }
            set
            {
                pclave = value;
            }
        }
        public String usuario
        {
            get
            {
                return pusuario;
            }
            set
            {
                pusuario = value;
            }
        }

        public Usuarios()
        {

            //
            // TODO: Add constructor logic here
            //
        }
        public Usuarios(String usuario)
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("SELECT usuario,clave,fecha1,hora1,fecha2,hora2,condicion,perfil FROM Usuarios where usuario='" + usuario + "'");

            if (drSQL != null)
            {
                pusuario = usuario;

                pclave = drSQL["clave"].ToString();
                if (drSQL["fecha1"].ToString() == "")
                    pfecha1 = Convert.ToDateTime("01/01/1901");
                else
                    pfecha1 = Convert.ToDateTime(drSQL["fecha1"].ToString());
                phora1 = drSQL["hora1"].ToString();
                if (drSQL["fecha2"].ToString() == "")
                    pfecha2 = Convert.ToDateTime("01/01/1901");
                else
                    pfecha2 = Convert.ToDateTime(drSQL["fecha2"].ToString());

                phora2 = drSQL["hora2"].ToString();
                pcondicion = drSQL["condicion"].ToString();
                pperfil = drSQL["perfil"].ToString();
            }
            else
            {
                pusuario = "";
                pclave = "";
                pfecha1 = Convert.ToDateTime("01/01/1901");
                phora1 = "";
                pfecha2 = Convert.ToDateTime("01/01/1901");
                phora2 = "";
                pcondicion = "A";
                pperfil = "";
            }

        }
        public int CantReg()
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("select isnull(count(*),0) as cantreg FROM Usuarios");

            return Int32.Parse(drSQL["cantreg"].ToString());

        }

        public DataTable ObtenerTodos()
        {

            BDComun d = new BDComun();
            return d.DatosTabla("SELECT usuario,clave,fecha1,hora1,fecha2,hora2,condicion,perfil FROM Usuarios");

        }
        public DataTable ObtenerTodos2()
        {

            BDComun d = new BDComun();
            return d.DatosTabla("SELECT usuario,clave,fecha1,hora1,fecha2,hora2,condicion,perfil FROM Usuarios where usuario<>'ADMINISTRADOR' order by usuario");

        }
        public DataTable ObtenerTodosBusqueda(String SqlQuery)
        {

            BDComun d = new BDComun();
            return d.DatosTabla("SELECT usuario,clave,fecha1,hora1,fecha2,hora2,condicion,perfil FROM Usuarios where " + SqlQuery + " 1=1 ");

        }
        public bool ExisteReg(String usuario)
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("select isnull(count(*),0) as cantreg FROM Usuarios where usuario='" + usuario + "'");

            if (Int32.Parse(drSQL["cantreg"].ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EstaActivo(String usuario)
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("select isnull(count(*),0) as cantreg FROM Usuarios where condicion='ACTIVO' and usuario='" + usuario + "'");

            if (Int32.Parse(drSQL["cantreg"].ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ClaveCorrecta(String usuario, String password)
        {
            BDComun d = new BDComun();

            DataRow drSQL = d.RegistroTabla("select isnull(count(*),0) as cantreg FROM Usuarios where condicion='ACTIVO' and usuario='" + usuario + "' and clave='" + password + "'");

            if (Int32.Parse(drSQL["cantreg"].ToString()) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Agregar()
        {
            BDComun d = new BDComun();
            String strSQL = "insert into Usuarios( usuario,clave,fecha1,hora1,fecha2,hora2,condicion,perfil) values('" + pusuario + "','" + pclave + "','" + pfecha1.ToString("yyyyMMdd") + "','" + phora1 + "','" + pfecha2.ToString("yyyyMMdd") + "','" + phora2 + "','" + pcondicion + "','" + pperfil + "')";
            d.ActualizarTabla(strSQL);

        }
        public void Modificar()
        {
            BDComun d = new BDComun();
            String strSQL = "update Usuarios set usuario='" + pusuario + "', clave='" + pclave + "',fecha1='" + pfecha1.ToString("yyyyMMdd") + "',hora1='" + phora1 + "',fecha2='" + pfecha2.ToString("yyyyMMdd") + "',hora2='" + phora2 + "' ,condicion='" + pcondicion + "',perfil='" + pperfil + "' where usuario='" + pusuario + "'";
            d.ActualizarTabla(strSQL);

        }
        public void Eliminar(String usuario)
        {
            BDComun d = new BDComun();
            String strSQL = "Delete Usuarios where usuario='" + usuario + "'";
            d.ActualizarTabla(strSQL);

        }

    }
}
