
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHAD_TULIO
{
    public partial class FormCustomer : Form
    {
        
        int operacion = 0;
        ENTIDAD.CustomerTypes CustomerTypes = new ENTIDAD.CustomerTypes();
        public FormCustomerType()
        {
            InitializeComponent();
          
        }

        private void clienteProgramaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void DEPARTAMENTOS_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            try
            {
                this.Text = this.Text + VariablesGlobales.sistema;
          
                tbldepartamentoDataGridView.DataSource = CustomerTypes.ObtenertodosCustomerTypes();


                miestilo estilo = new miestilo();
                estilo.DataGrid (tbldepartamentoDataGridView);

                codDptoTextBox.Enabled = false;
              
                descripcionTextBox.Enabled = false;
               
                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;


                btcancelar.Enabled = false;
                btguardar.Enabled = false;
                


             
                
       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

      

        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 1;
              //  codDptoTextBox.Enabled = false;
                
                descripcionTextBox.Enabled = true;
                descripcionTextBox.Text = "";
                codDptoTextBox.Text = "";
                button2.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = false;
              
                btcancelar.Enabled = true;
                btguardar.Enabled = true;


                
                codDptoTextBox.Text = Convert.ToString(CustomerTypes.obteneridsiguiente());
               
               
            }
            catch (Exception ex)
            {
                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btguardar.Enabled = false;
            //    codDptoTextBox.Enabled = false;
               
                descripcionTextBox.Enabled = false;
             
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        
        }

        private void clienteProgramaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            try {

                if (operacion == 1)
                {


                    CustomerTypes.InsertQuery (descripcionTextBox.Text);


                    MessageBox.Show("Registro Agregado");
                    

                }
                if (operacion == 2)
                {
                    CustomerTypes.UpdateQuery(Convert.ToInt32(codDptoTextBox.Text),descripcionTextBox.Text);

                    MessageBox.Show("Registro Modificado"); 
                }

                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btguardar.Enabled = false;
             //   codDptoTextBox.Enabled = false;
      
                descripcionTextBox.Enabled = false;


                tbldepartamentoDataGridView.DataSource = CustomerTypes.ObtenertodosCustomerTypes();

            }
            catch (Exception ex)
            {
                button2.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = false;
                btcancelar.Enabled = true;
                btguardar.Enabled = true;
               // codDptoTextBox.Enabled = true;
              
                descripcionTextBox.Enabled = true;
            
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

       
        private void bteditar_Click(object sender, EventArgs e)
        {
            try { 
            operacion = 2;
     
          
                button2.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = false;
                btcancelar.Enabled = true;
                btguardar.Enabled = true;
             //   codDptoTextBox.Enabled = true;
              
                descripcionTextBox.Enabled = true;
               




            }
            catch (Exception ex)
            {
                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btguardar.Enabled = false;
              //  codDptoTextBox.Enabled = false;
              
                descripcionTextBox.Enabled = false;
             
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
}

     
        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 0;

                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;
                btcancelar.Enabled = false;
                btguardar.Enabled = false;

             //   codDptoTextBox.Enabled = false;
              
                descripcionTextBox.Enabled = false;
      
              
            }
            catch (Exception ex)
            {
                button2.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = false;
                btcancelar.Enabled = true;
                btguardar.Enabled = true;
              //  codDptoTextBox.Enabled = true;
              
                descripcionTextBox.Enabled = true;
            
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                DialogResult Dialogo = MessageBox.Show("Esta seguro que desea Borrar este Registro",
                   "Borrarando Registro", MessageBoxButtons.YesNo);
                if (Dialogo == DialogResult.Yes)
                {
                    CustomerTypes.DeleteQuery(Convert.ToInt32(codDptoTextBox.Text));

                    MessageBox.Show("Registro Eliminado Correctamente", "", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                    tbldepartamentoDataGridView.DataSource = CustomerTypes.ObtenertodosCustomerTypes();

                }
                if (Dialogo == DialogResult.No)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbldepartamentoDataGridView_Click(object sender, EventArgs e)
        {
            codDptoTextBox.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["CodDpto"].Value);
            descripcionTextBox.Text= (string) tbldepartamentoDataGridView.CurrentRow.Cells["Descripcion"].Value;
        }
    }
}

