using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Data.SqlClient;

namespace SCHAD_TULIO
{
    public partial class loguin : Form
    {
     //   public home menu;
      
        public loguin()
        {
           
            InitializeComponent();
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            if (cmbusuarios.Text == "" || txt2.Text == ""  )
            {

                MessageBox.Show("por favor completar los Campos", "Complete los Campos Obligatorios");

            }
            else
            {
              Usuarios usu   = new Usuarios();
               
                if (usu.ClaveCorrecta(cmbusuarios.Text, txt2.Text) ==true)
                {


                    Validaryentrar();

                
                }
                else
                {
                    MessageBox.Show("Revise su Usuario y/o Constraseña por favor", "Este Usuario no Existe en nuestra Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            }




        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Usuarios usu = new Usuarios();
                if (usu.ClaveCorrecta(cmbusuarios.Text, txt2.Text) ==true)
                {
                    Validaryentrar();
                }
                else
                {
                    MessageBox.Show("Revise su Usuario y/o Constraseña por favor", "Este Usuario no Existe en nuestra Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
    }

        private void loguin_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + VariablesGlobales.sistema;
            DoubleBuffered = true;

            try
            {
                using ( SqlConnection cnn              = BDComun.Siif()) {

                    BDComun a = new  BDComun();
                    a.conexionTest();
                        
                }





               

                Usuarios usu             = new Usuarios();
                this.cmbusuarios.DataSource             = usu.ObtenerTodos();//Tipo DataTable
                this.cmbusuarios.DisplayMember          = "Nombre";
                this.cmbusuarios.ValueMember            = "Usuario";


               

          




                Recordando();

            }
            catch (SqlException)
            {


                FrmBuscarServidor BUS = new FrmBuscarServidor();
                MessageBox.Show("Hemos detectado un error en la conexión a la Bade de Datos, por favor contactar al Soporte de Sistema", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BUS.ShowDialog();

            }

        }
        private void Memorizando()
        {

            

            Utilidades.Recordar rec     = new Utilidades.Recordar();
      
      
            rec.Usuario                 = cmbusuarios.SelectedValue.ToString();

            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();

            string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
            if (System.IO.Directory.Exists(mdoc) == false)
                System.IO.Directory.CreateDirectory(mdoc);

            Stream stream = new FileStream(mdoc + "\\" + "Recuerda.bin", FileMode.Create, FileAccess.Write, FileShare.None);
       
            stream.Close();
        }
        private void Recordando()
        {
            string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
            if (System.IO.Directory.Exists(mdoc) == false)
                System.IO.Directory.CreateDirectory(mdoc);

            if (File.Exists(mdoc + "\\" + "Recuerda.bin") == true)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(mdoc + "\\" + "Recuerda.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
           
                stream.Close();

            

            

            }
        }

        public void Validaryentrar()
        {
           

           
                VariablesGlobales.Usuario           = cmbusuarios.SelectedValue.ToString();
      
          




            Memorizando ();

              this.Hide();
            
                        
            home home = new home ();
            
            home.ShowDialog();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void parametrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void parametrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
           

        }

        private void parametrosBindingSource_CurrentChanged (object sender , EventArgs e)
        {

        }
    }
}

