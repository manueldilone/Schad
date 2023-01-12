
using SCHAD_TULIO.ENTIDAD;
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
        ENTIDAD.Customers Customers = new ENTIDAD.Customers();
        ENTIDAD.CustomerTypes customerTypes = new ENTIDAD.CustomerTypes();
        public FormCustomer()
        {
            InitializeComponent();
          
        }

        private void clienteProgramaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        public void actualizar()
        {
            tbldepartamentoDataGridView.DataSource = Customers.ObtenerTodosCustomer();
        }

        public void ActivarControles(Boolean valor)
        {
            txtid.Enabled = valor;

            txtname.Enabled = valor;
            btcancelar.Enabled = valor;
            btguardar.Enabled = valor;

            txtname.Enabled = valor;
            txtid.Enabled = valor;



            txtAdress.Enabled = valor;
            ckstatus.Enabled = valor;
            cmbcustomertype.Enabled = valor;



            if (valor == false)
            {
                button2.Enabled = true;
                btagregar.Enabled = true;
                bteditar.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                btagregar.Enabled = false;
                bteditar.Enabled = false;
            }

            }

        public void limpiarcampos()
        {
            txtname.Text = "";
            txtid.Text = "";


            
                txtAdress.Text = "";
            ckstatus.Checked = true;
            cmbcustomertype.Text = "";
        }

        private void DEPARTAMENTOS_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;

            try
            {
                this.Text = this.Text + VariablesGlobales.sistema;

                actualizar();


                miestilo estilo = new miestilo();
                estilo.DataGrid (tbldepartamentoDataGridView);

                ActivarControles(false);












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


                ActivarControles(true);


                limpiarcampos();





                txtid.Text = Convert.ToString(Customers.obteneridsiguienteCustomer());
               
               
            }
            catch (Exception ex)
            {


                ActivarControles(false);

                
             
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


                    Customers.InsertQuery (txtname.Text,txtAdress.Text,ckstatus.Checked ? 1: 0, Convert.ToInt32(cmbcustomertype.SelectedValue));


                    MessageBox.Show("Registro Agregado");
                    

                }
                if (operacion == 2)
                {
                    Customers.UpdateQuery(Convert.ToInt32(txtid.Text), txtname.Text, txtAdress.Text, ckstatus.Checked ? 1 : 0, Convert.ToInt32(cmbcustomertype.SelectedValue));

                    MessageBox.Show("Registro Modificado"); 
                }

                ActivarControles(false);


                actualizar();

            }
            catch (Exception ex)
            {
                ActivarControles(true);

                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

       
        private void bteditar_Click(object sender, EventArgs e)
        {
            try { 
            operacion = 2;


                ActivarControles(true);





            }
            catch (Exception ex)
            {
                ActivarControles(false);

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

                ActivarControles(false);


            }
            catch (Exception ex)
            {
                ActivarControles(true);

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
                    Customers.DeleteQuery(Convert.ToInt32(txtid.Text));

                    MessageBox.Show("Registro Eliminado Correctamente", "", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                    actualizar();

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
            CustomerTypes CustomerTypes = new CustomerTypes();
            txtid.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["Id"].Value);
            txtname.Text= (string) tbldepartamentoDataGridView.CurrentRow.Cells["CustName"].Value;
            txtAdress.Text = (string)tbldepartamentoDataGridView.CurrentRow.Cells["Adress"].Value;
            ckstatus.Checked = (Boolean) tbldepartamentoDataGridView.CurrentRow.Cells["Status"].Value;
            
            
            cmbcustomertype.Text = CustomerTypes.getDescription(Convert.ToInt32(tbldepartamentoDataGridView.CurrentRow.Cells["CustomerTypeId"].Value));
        }

        private void tbldepartamentoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {

                if (this.tbldepartamentoDataGridView.Columns[e.ColumnIndex].Name == "Status")
                    if (Convert.ToBoolean(e.Value).Equals(true))
                    {
                        e.CellStyle.BackColor = Color.Green;

                        e.Value = "Activo";
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Red;

                        e.Value = "Inactivo";
                    }
                if (this.tbldepartamentoDataGridView.Columns[e.ColumnIndex].Name == "CustomerTypeid")

                {
                    e.Value = customerTypes.getDescription(Convert.ToInt32(e.Value));
                }
                   
                   
               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbcustomertype_Click(object sender, EventArgs e)
        {
            CustomerTypes customerTypes = new CustomerTypes();
            this.cmbcustomertype.DataSource = customerTypes.ObtenertodosCustomerTypes();

            this.cmbcustomertype.DisplayMember = "Description";
            this.cmbcustomertype.ValueMember = "Id";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

