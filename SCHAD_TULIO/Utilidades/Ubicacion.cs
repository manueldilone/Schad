using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHAD_TULIO
{
    class Ubicacion
    {



      
        public static void ObtenerServidor(out String pservidor, out String pbasededatos, out String pusuario, out String pclave, out String pautenticacionwindows)
        {

            try
            {
                pservidor = "";
                pusuario = "";
                pclave = "";
                pbasededatos = "";
                pautenticacionwindows = "N";

                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
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
                    pbasededatos = sr.ReadLine();
                    pusuario = sr.ReadLine();
                    pclave = sr.ReadLine();
                    pautenticacionwindows = sr.ReadLine();

                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pservidor = "";
                pbasededatos = "";
                pusuario = "";
                pclave = "";
                pautenticacionwindows = "N";
                return;
            }
        }
        public static bool ExisteUbicacionServidor()
        {

            try
            {


                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\RutaServidor.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    return false;

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void EstablecerServidor(String NombreServidor, String NombreBasedeDatos, String Usuario, String Clave, String AutenticacionWindows)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\RutaServidor.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(NombreServidor);
                sw.WriteLine(NombreBasedeDatos);
                sw.WriteLine(Usuario);
                sw.WriteLine(Clave);
                sw.WriteLine(AutenticacionWindows);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        public static void EstablecerConfiguracionRegional(String aplica, String separadordecimal, String separadormiles, String separadorlistas, String fechacorta, String horacorta, String horalarga)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\ConfiguracionRegional.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(aplica);
                sw.WriteLine(separadordecimal);
                sw.WriteLine(separadormiles);
                sw.WriteLine(separadorlistas);
                sw.WriteLine(fechacorta);
                sw.WriteLine(horacorta);
                sw.WriteLine(horalarga);


                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static String UbicacionAyuda()
        {

            try
            {
                String RutaAyuda = "";
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                RutaAyuda = AppDomain.CurrentDomain.BaseDirectory + @"Ayuda\";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto


                return RutaAyuda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public static void EstablecerDatosPOS(String CodCaja, String CodVendedor, String CodAlmacen, String CodCliente, String ArticuloDesconectado, String AbrirDiseno, String Recordar)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\DatosPOS.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(CodCaja);
                sw.WriteLine(CodVendedor);
                sw.WriteLine(CodAlmacen);
                sw.WriteLine(CodCliente);
                sw.WriteLine(ArticuloDesconectado);
                sw.WriteLine(AbrirDiseno);
                sw.WriteLine(Recordar);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void ObtenerDatosPOS(out String CodCaja, out String CodVendedor, out String CodAlmacen, out String CodCliente, out String ArticuloDesconectado, out String AbrirDiseno, out String Recordar)
        {

            try
            {
                CodCaja = "";
                CodVendedor = "";
                CodAlmacen = "";
                CodCliente = "";
                ArticuloDesconectado = "";
                AbrirDiseno = "";
                Recordar = "";
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\DatosPOS.txt";
                //si no existe el txt lo creamos con los valores por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    CodCaja = "";
                    CodVendedor = "";
                    CodAlmacen = "";
                    CodCliente = "";
                    ArticuloDesconectado = "Si";
                    AbrirDiseno = "Si";
                    Recordar = "Si";

                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line
                    CodCaja = sr.ReadLine();
                    CodVendedor = sr.ReadLine();
                    CodAlmacen = sr.ReadLine();
                    CodCliente = sr.ReadLine();
                    ArticuloDesconectado = sr.ReadLine(); ;
                    AbrirDiseno = sr.ReadLine();
                    Recordar = sr.ReadLine();

                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodCaja = "";
                CodVendedor = "";
                CodAlmacen = "";
                CodCliente = "";
                ArticuloDesconectado = "Si";
                AbrirDiseno = "Si";
                Recordar = "Si";
                return;
            }
        }
        public static void EstablecerDisenoPOS(String frmestado, int frmancho, int frmaltura, int split1ancho, int split2ancho, int split3ancho)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\DisenoPOS.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(frmestado);
                sw.WriteLine(frmancho);
                sw.WriteLine(frmaltura);
                sw.WriteLine(split1ancho);
                sw.WriteLine(split2ancho);
                sw.WriteLine(split3ancho);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void ObtenerDisenoPOS(out String frmestado, out int frmancho, out int frmaltura, out int split1ancho, out int split2ancho, out int split3ancho)
        {

            try
            {
                frmestado = "Maximized";
                frmancho = 0;
                frmaltura = 0;
                split1ancho = 0;
                split2ancho = 0;
                split3ancho = 0;

                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\DisenoPOS.txt";
                //si no existe el txt lo creamos con los valores por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    frmestado = "Maximized";
                    frmancho = 0;
                    frmaltura = 0;
                    split1ancho = 0;
                    split2ancho = 0;
                    split3ancho = 0;

                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line
                    frmestado = sr.ReadLine();
                    frmancho = Int32.Parse(sr.ReadLine());
                    frmaltura = Int32.Parse(sr.ReadLine());
                    split1ancho = Int32.Parse(sr.ReadLine());
                    split2ancho = Int32.Parse(sr.ReadLine());
                    split3ancho = Int32.Parse(sr.ReadLine());

                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmestado = "Maximized";
                frmancho = 0;
                frmaltura = 0;
                split1ancho = 0;
                split2ancho = 0;
                split3ancho = 0;
                return;
            }
        }
        public static void EstablecerSuperSpoolerPOS(String Equipo, String CarpetaDestino)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\SuperSpoolerPOS.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(Equipo);
                sw.WriteLine(CarpetaDestino);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void ObtenerSuperSpoolerPOS(out String Equipo, out String CarpetaDestino)
        {

            try
            {
                Equipo = "tulio.001";
                CarpetaDestino = @"C:\FACTURAS";

                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\SuperSpoolerPOS.txt";
                //si no existe el txt lo creamos con los valores por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    Equipo = "tulio.001";
                    CarpetaDestino = @"C:\FACTURAS";

                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line
                    Equipo = sr.ReadLine();
                    CarpetaDestino = sr.ReadLine();

                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Equipo = "tulio.001";
                CarpetaDestino = @"C:\FACTURAS";

                return;
            }
        }
        public static void EstablecerImpresoraPOS(String puerto, String velocidad, String nombreimpresora)
        {

            try
            {
                //System.IO.Path.GetDirectoryName( esto obitene el directorio previo de un archivo
                //ruta del archivo que contiene el path del reporte
                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\ImpresoraPOS.txt";
                //si no existe el txt que me da la ruta de los reporte y lo creamos con la ruta del path del exe por defecto

                System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta);
                sw.WriteLine(puerto);
                sw.WriteLine(velocidad);
                sw.WriteLine(nombreimpresora);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void ObtenerImpresoraPOS(out String puerto, out String velocidad, out String nombreimpresora)
        {

            try
            {

                puerto = "";
                velocidad = "";
                nombreimpresora = "";

                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\ImpresoraPOS.txt";
                //si no existe el txt lo creamos con los valores por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    puerto = "";
                    velocidad = "";
                    nombreimpresora = "";

                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line
                    puerto = sr.ReadLine();
                    velocidad = sr.ReadLine();
                    nombreimpresora = sr.ReadLine();
                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                puerto = "";
                velocidad = "";
                nombreimpresora = "";

                return;
            }
        }
        public static void ObtenerConfiguracionRegional(out String aplica, out String separadordecimal, out String separadormiles, out String separadorlistas, out String fechacorta, out String horacorta, out String horalarga)
        {

            try
            {

                aplica = "";
                separadordecimal = "";
                separadormiles = "";
                separadorlistas = "";
                fechacorta = "";
                horacorta = "";
                horalarga = "";

                string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                if (System.IO.Directory.Exists(mdoc) == false)
                    System.IO.Directory.CreateDirectory(mdoc);

                String ruta = mdoc + "\\ConfiguracionRegional.txt";
                //si no existe el txt lo creamos con los valores por defecto
                if (!System.IO.File.Exists(ruta))
                {
                    aplica = "";
                    separadordecimal = "";
                    separadormiles = "";
                    separadorlistas = "";
                    fechacorta = "";
                    horacorta = "";
                    horalarga = "";

                }
                else
                {
                    //leer el path de la ubicacion del servidor
                    StreamReader sr = new StreamReader(ruta);
                    //Read the next line


                    aplica = sr.ReadLine();
                    separadordecimal = sr.ReadLine();
                    separadormiles = sr.ReadLine();
                    separadorlistas = sr.ReadLine();
                    fechacorta = sr.ReadLine();
                    horacorta = sr.ReadLine();
                    horalarga = sr.ReadLine();
                    sr.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aplica = "";
                separadordecimal = "";
                separadormiles = "";
                separadorlistas = "";
                fechacorta = "";
                horacorta = "";
                horalarga = "";
                return;
            }
        }
      
    }
}