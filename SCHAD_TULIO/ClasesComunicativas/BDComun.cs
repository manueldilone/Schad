using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SCHAD_TULIO
{
    internal class BDComun
    {
        String pservidor;
        String pnombrebasededatos;
        String pusuario;
        String pclave;
        String pautenticacionwindows;
        String Carpeta = "Schad.Net";
        private String pCnStr;
        public String servidor
        {
            get
            {
                return pservidor;
            }
            set
            {
                pservidor = value;
            }

        }
        public String nombrebasededatos
        {
            get
            {
                return pnombrebasededatos;
            }
            set
            {
                pnombrebasededatos = value;
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
        public String autenticacionwindows
        {
            get
            {
                return pautenticacionwindows;
            }
            set
            {
                pautenticacionwindows = value;
            }

        }
        public BDComun()
        {
            UbicacionDeServidor();
          
        }

       

        private void UbicacionDeServidor()
        {
            try
            {
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\RutaServidor.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    pservidor = @"(local)\SQLEXPRESS";
                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line
                    pservidor = sr.ReadLine();
                    pnombrebasededatos = sr.ReadLine();
                    pusuario = sr.ReadLine();
                    pclave = sr.ReadLine();
                    pautenticacionwindows = sr.ReadLine();

                    sr.Close();

                }


                if (pautenticacionwindows == "N")
                    pCnStr = (@"Data Source=" + pservidor + ";Initial Catalog=" + pnombrebasededatos + ";User Id=" + pusuario + " ;Password=" + pclave + "");
                //  pCnStr = (@"Data Source=201.248.204.82,1433; Network Library=DBMSSOCN; Initial Catalog=Contable; User ID=sa; Password=12345"); 

                else
                    pCnStr = ("Data Source=" + pservidor + ";Initial Catalog=" + pnombrebasededatos + ";Integrated Security=True");

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static SqlConnection Siif()

        {

            BDComun d = new BDComun();
            //SqlConnection cnSQL;

            SqlConnection cnSQL = new SqlConnection(d.pCnStr);
            cnSQL.Open();
            return cnSQL;
        }






        public DataRow RegistroTabla(String Cm)
        {
            try
            {
                SqlConnection cnSQL;
                SqlDataAdapter daSQL;
                DataSet DS;

                DS = new DataSet();

                cnSQL = new SqlConnection(pCnStr);
                daSQL = new SqlDataAdapter(Cm, cnSQL);
                daSQL.Fill(DS);


                if (DS.Tables[0].Rows.Count > 0)
                    return DS.Tables[0].Rows[0];
                else
                    return null;


            }
            catch (SqlException e)
            {
                MessageBox.Show("Error:" + e.ErrorCode.ToString() + ",  " + e.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), " General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }

        public void ActualizarTabla(String strSQL)
        {
            try
            {
                SqlConnection cnSQL;
                SqlCommand cmSQL;


                cnSQL = new SqlConnection(this.pCnStr);
                cnSQL.Open();
                cmSQL = new SqlCommand(strSQL, cnSQL);
          

                cmSQL.ExecuteNonQuery();
                cnSQL.Close();
                cnSQL.Dispose();
                return;

            }
            catch (SqlException e)
            {
                MessageBox.Show("Error:" + e.ErrorCode.ToString() + ",  " + e.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), " General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;

        }

        public void conexionTest()
        {
            try
            {


                String servidor;
                String basededatos;
                String usuario;
                String clave;
                String autenticacionwindows;

        
                Ubicacion.ObtenerServidor(out servidor, out basededatos, out usuario, out clave, out autenticacionwindows);

                VariablesGlobales.DBPRINCIPAL = basededatos + ".[dbo]";


                String separadordecimal = VariablesGlobales.miCultura.NumberFormat.NumberDecimalSeparator;
                String separadorlista = VariablesGlobales.miCultura.TextInfo.ListSeparator;
                String separadormiles = VariablesGlobales.miCultura.NumberFormat.NumberGroupSeparator;
                String horacorta = VariablesGlobales.miCultura.DateTimeFormat.ShortTimePattern;
                String horalarga = VariablesGlobales.miCultura.DateTimeFormat.LongTimePattern;
                String fechacorta = VariablesGlobales.miCultura.DateTimeFormat.ShortDatePattern;
             


              
       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public DataTable DatosTabla(String Cm)
        {
            try
            {
                SqlConnection cnSQL;
                SqlDataAdapter daSQL;
                DataSet DS;

                DS = new DataSet();


                cnSQL = new SqlConnection(pCnStr);
                daSQL = new SqlDataAdapter(Cm, cnSQL);
                daSQL.Fill(DS);
                return DS.Tables[0];


            }
            catch (SqlException e)
            {
                MessageBox.Show("Error:" + e.ErrorCode.ToString() + ",  " + e.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), " General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }


    }
}
