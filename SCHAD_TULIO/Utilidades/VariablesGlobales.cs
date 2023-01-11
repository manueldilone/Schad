using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHAD_TULIO
{
    class VariablesGlobales
    {

        static string Glo_sistema = " - [Schad] - Sistema de Prueba Tecnica a Tulio Mercedes ";

        static string Glo_dbprincipal = "";
        static int Glo_Ejercicio = 0;
        static int Glo_Mes = 0;
        static int Glo_Año = 0;
        static string Glo_Usuario = "";
        static int Glo_CantidadRegistroPagina = 100;
      
        static string Glo_Carpeta = "Schad.Net";
        static System.Globalization.CultureInfo Glo_miCultura;

        public static String sistema { get { return Glo_sistema; } }
       
        public static int Ejercicio
        {
            get { return Glo_Ejercicio; }
            set { Glo_Ejercicio = value; }
        }
        public static int Mes
        {
            get { return Glo_Mes; }
            set { Glo_Mes = value; }
        }

        public static String DBPRINCIPAL { get { return Glo_dbprincipal; } set { Glo_dbprincipal = value; } }
        public static int Año
        {
            get { return Glo_Año; }
            set { Glo_Año = value; }
        }
        public static string Usuario
        {
            get { return Glo_Usuario; }
            set { Glo_Usuario = value; }
        }
        public static int CantidadRegistroPagina
        {
            get { return Glo_CantidadRegistroPagina; }
            set { Glo_CantidadRegistroPagina = value; }
        }
       
        public static string Carpeta
        {
            get { return Glo_Carpeta; }
            set { Glo_Carpeta = value; }
        }
        public static System.Globalization.CultureInfo miCultura
        {
            get { return Glo_miCultura; }
            set { Glo_miCultura = value; }
        }
    }
}
