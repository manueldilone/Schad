using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHAD_TULIO
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VariablesGlobales.miCultura = System.Globalization.CultureInfo.CurrentCulture;

            Application.Run(new loguin());

            // Application.Run (new _13_EJECUCION_PRESUPUESTARIA.BuscarPartidaGasto ());
        }
    }
}