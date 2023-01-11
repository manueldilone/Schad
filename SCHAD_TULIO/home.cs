
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHAD_TULIO
{
    

    public partial class home : Form
    {
        public int accesoaprobado = 0;
       
        public home()
        {
            InitializeComponent();
           
        }



        private void home_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + VariablesGlobales.sistema;
            DoubleBuffered = true;

           
                toolStripStatusLabel2.Text = "Usuario: " + VariablesGlobales.Usuario;
                toolStripStatusLabel1.Text = "Fecha de hoy: " + DateTime.Now.ToString ();
                toolStripStatusLabel12.Text = VariablesGlobales.sistema;


  


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
          
        }

       

     

      

        private void establecerServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmBuscarServidor ser = new FrmBuscarServidor();
            ser.ShowDialog();
            
        }

      


       
      

      
        private void Button4_Click(object sender, EventArgs e)
        {

           

        
        }

    }
}
  




