using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;






namespace SCHAD_TULIO
{
    public partial class FrmBuscarServidor : Form
    {
        
      
        public FrmBuscarServidor()
        {
            InitializeComponent();
        }

        private void cmdbuscar_Click(object sender, EventArgs e)
        {
            try 
            {
            SqlDataSourceEnumerator Descubridor_de_sql = SqlDataSourceEnumerator.Instance;
            DataTable sqls = Descubridor_de_sql.GetDataSources();
           
            cmbservidor.Items.Clear();
            foreach (DataRow servSQL in sqls.Rows)
            {

             //   listBox1.Items.Add("**********************************************");
              //  listBox1.Items.Add("Nombre del servidor:" + servSQL["ServerName"]);
               // listBox1.Items.Add("Nombre de la instancia:" + servSQL["InstanceName"]);
                //listBox1.Items.Add("Versión:" + servSQL["Version"]);
             //   String variable = (servSQL["IsClustered"].ToString() == "No" ? "No" : "Si");
             //   listBox1.Items.Add("¿Está en cluster?:" + servSQL["IsClustered"]);

                cmbservidor.Items.Add(servSQL["ServerName"]);
                cmbservidor.Items.Add(servSQL["ServerName"] + @"\SQLEXPRESS");

            }

            //comboBox1.Items.Add(@"(Local)\SQLEXPRESS");
            //el guille
            string[] instancias;
            instancias = instanciasInstaladas();
            foreach (string s in instancias)
            {
                if (s == "MSSQLSERVER")
                {
                    cmbservidor.Items.Add("(local)");
                }
                else
                {
                    cmbservidor.Items.Add(@"(local)\" + s);
                }
            }

            MessageBox.Show("Listo. Seleccione en la lista", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
        catch (Exception ex)
        {
            MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

      
   private String[] instanciasInstaladas()
        {
       try
       {
            Microsoft.Win32.RegistryKey rk;
            rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
            string[] s;
            s = ((String[])rk.GetValue("InstalledInstances"));
            return s;
          }
        catch (Exception ex)
        {
            MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        }

        private void FrmBuscarServidor_Load(object sender, EventArgs e)
        {
            try
            {


                String servidor;
                String basededatos;
                String usuario;
                String clave;
                String autenticacionwindows;
              
                Ubicacion.ObtenerServidor(out servidor, out basededatos, out usuario, out clave, out autenticacionwindows);
                VariablesGlobales.DBPRINCIPAL = basededatos+ "+.[dbo]+";

                cmbservidor.Text = servidor;
                cmbbasededatos.Text = basededatos;
                txtusuario.Text = usuario;
                txtcontrasena.Text = clave;
                checkBox1.Checked = (autenticacionwindows == "S" ? true : false);
      

                
                String separadordecimal = VariablesGlobales.miCultura.NumberFormat.NumberDecimalSeparator;
                String separadorlista = VariablesGlobales.miCultura.TextInfo.ListSeparator;
                String separadormiles = VariablesGlobales.miCultura.NumberFormat.NumberGroupSeparator;
                String horacorta = VariablesGlobales.miCultura.DateTimeFormat.ShortTimePattern;
                String horalarga = VariablesGlobales.miCultura.DateTimeFormat.LongTimePattern;
                String fechacorta = VariablesGlobales.miCultura.DateTimeFormat.ShortDatePattern;
                txtseparadordecimal.Text = separadordecimal;
                txtseparadordelistas.Text = separadorlista;
                txtseparadordemiles.Text = separadormiles;
                txthoracorta.Text = horacorta;
                txthoralarga.Text = horalarga;
                txtfechacorta.Text = fechacorta;


                string aplica2 = "";
                string separadordecimal2 = "";
                string separadormiles2 = "";
                string separadorlistas2 = "";
                string fechacorta2 = "";
                string horacorta2 = "";
                string horalarga2 = "";
                Ubicacion.ObtenerConfiguracionRegional(out aplica2, out separadordecimal2, out separadormiles2, out separadorlistas2, out fechacorta2, out horacorta2, out horalarga2);
                if (aplica2 != "")
                {
                    txtseparadordecimal2.Text = separadordecimal2;
                    txtseparadordelistas2.Text = separadorlistas2;
                    txtseparadordemiles2.Text = separadormiles2;
                    txthoracorta2.Text = horacorta2;
                    txthoralarga2.Text = horalarga;
                    txtfechacorta2.Text = fechacorta2;

                }
                if (aplica2 == "" || aplica2 == "No")
                {
                    radioButton2.Checked = true;
                }
                if (aplica2 == "Si")
                {
                    radioButton1.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

     

        private void cmdsalir_Click(object sender, EventArgs e)
        {

               
                
                this.Close();
           
        }

        private void cmdcancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdaplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbbasededatos.Text.Trim() == "")
                {
                    MessageBox.Show("El Nombre de la Base de Datos está vacío", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            if (checkBox1.Checked == false && txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("El Usuario está vacío", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (cmbservidor.Text.Trim() != "")
            {
                Ubicacion.EstablecerServidor(cmbservidor.Text,cmbbasededatos.Text, txtusuario.Text, txtcontrasena.Text, checkBox1.Checked == true ? "S" : "N");
       
                Ubicacion.EstablecerConfiguracionRegional(radioButton1.Checked == true ? "Si" : "No", txtseparadordecimal2.Text, txtseparadordemiles2.Text, txtseparadordelistas2.Text, txtfechacorta2.Text, txthoracorta2.Text, txthoralarga2.Text);
               
                MessageBox.Show("Servidor Establecido. Presione Probar Conexión BD o Salir", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Servidor está vacío", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               }
        catch (Exception ex)
        {
            MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private void cmdatachar_Click(object sender, EventArgs e)
        {
            try
            {
            String cadenaDeConexion = ("Data Source=" + cmbservidor.Text + ";Integrated Security=True");
            using (SqlConnection cn = new SqlConnection(cadenaDeConexion))
            {
                    string mdoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    mdoc = mdoc + "\\" + VariablesGlobales.Carpeta;
                    if (System.IO.Directory.Exists(mdoc) == false)
                        System.IO.Directory.CreateDirectory(mdoc);

                    cn.Open();
               String archivo_mdf = mdoc + "\\"+ this.cmbbasededatos.Text+".mdf";

               String archivo_ldf = mdoc + "\\" + this.cmbbasededatos.Text + "_Log.ldf";


               SqlCommand cmd = new SqlCommand(@" USE [master] ; CREATE DATABASE [" + this.cmbbasededatos.Text + "] ON ( FILENAME = N'" + archivo_mdf + "' )," +
                    " ( FILENAME = N'"+archivo_ldf+"' )FOR ATTACH ; " +
                    " IF EXISTS ( SELECT name FROM master.sys.databases sd WHERE name = N'" + this.cmbbasededatos.Text + "' AND SUSER_SNAME(sd.owner_sid) = SUSER_SNAME() ) EXEC [" + this.cmbbasededatos.Text + "].dbo.sp_changedbowner @loginame=N'sa', @map=0 ;" +
                    " ALTER LOGIN sa ENABLE ; " +
                    " alter LOGIN [sa] WITH PASSWORD=N'"+txtcontrasena.Text +"', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON");
                


                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Finalizada el atachamiento", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               Usuarios usu = new Usuarios("ADMINISTRADOR");
                if (usu.usuario=="ADMINISTRADOR")
                    MessageBox.Show("Conexión Satisfactoria. Presione Salir", "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String archivomanegement = AppDomain.CurrentDomain.BaseDirectory + "\\Manuales Conexion Remota\\Habilitando puertos 1433.docx";
                System.Diagnostics.Process.Start(archivomanegement);
              }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                String archivomanegement = AppDomain.CurrentDomain.BaseDirectory + "\\Manuales Conexion Remota\\Como Configurar SQL Server 2005 para permitir conexiones remotas.docx";
                System.Diagnostics.Process.Start(archivomanegement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                String archivomanegement = AppDomain.CurrentDomain.BaseDirectory + "\\CrystalReport\\CRRuntime_32bit_13_0_18.msi";
                System.Diagnostics.Process.Start(archivomanegement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                String archivomanegement = AppDomain.CurrentDomain.BaseDirectory + "\\CrystalReport\\CRRuntime_64bit_13_0_18.msi";
                System.Diagnostics.Process.Start(archivomanegement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



      
    

       

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {

                string datosConexion = "Data Source=" + cmbservidor.Text + ";Initial Catalog=Master;Persist Security Info=True;User ID=" + txtusuario.Text + ";Password=" + txtcontrasena.Text + "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = datosConexion;
                con.Open();

                string textoCmd = "SELECT name, database_id, create_date FROM sys.databases";

                SqlDataAdapter daSQL;
                DataSet DS;

                DS = new DataSet();
                daSQL = new SqlDataAdapter(textoCmd, con);
                daSQL.Fill(DS);


                DataTable dtTable = DS.Tables[0];

                cmbbasededatos.DataSource = dtTable;
                cmbbasededatos.DisplayMember = "name";

                //foreach (DataRow dtRow in dtTable.Rows)
                //{
                //    dtRow["name"]
                //    //foreach(DataColumn dc in dtRow)
                //}



                //SqlConnection cnSQL;




                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");

            culture = (System.Globalization.CultureInfo)Application.CurrentCulture.Clone();

            culture.NumberFormat.NumberDecimalSeparator =  txtseparadordecimal.Text;
            culture.NumberFormat.NumberGroupSeparator = txtseparadordemiles.Text;
            culture.TextInfo.ListSeparator =txtseparadordelistas.Text ;
            
            //System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            Application.CurrentCulture = culture;
            
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            txtseparadordecimal2.Text = ".";
            txtseparadordemiles2.Text = ",";
            txtseparadordelistas2.Text = ";";
            txtfechacorta2.Text = "dd/MM/yyyy";
            txthoracorta2.Text = "h:mm tt";
            txthoralarga2.Text = "h:mm:ss tt";
            radioButton1.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtseparadordecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }

   
    
}