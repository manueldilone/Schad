
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
    public partial class FormInvoice : Form
    {

        int operacion = 0;
        ENTIDAD.Invoice nvoice = new ENTIDAD.Invoice();


        public FormInvoice()
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
                miestilo estilo = new miestilo();
                estilo.DataGrid(tbldepartamentoDataGridView);

                this.Text = this.Text + VariablesGlobales.sistema;

                actualizargrid();


                ActivarControles(false);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Precaución. " + ex.Message, "Sistemas Administrativos", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        public void ActivarControles(Boolean valor)
        {
            cmbcustomer.Enabled = valor;
            txtid.Enabled = valor;
            txtitbis.Enabled = valor;
            txtQty.Enabled = valor;
            txtprice.Enabled = valor;
            txtsubtotal.Enabled = valor;
            txttotal.Enabled = valor;
            btcancelar.Enabled = valor;
            btguardar.Enabled = valor;
            if (valor.Equals(false))
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
            cmbcustomer.Text = "";
            txtid.Text = "";
            txtitbis.Text = "";
            txtQty.Text = "";
            txtprice.Text = "";
            txtsubtotal.Text = "";
            txttotal.Text = "";


        }
        private void btagregar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 1;
                //  codDptoTextBox.Enabled = false;

                ActivarControles(true);

                limpiarcampos();

                Customers Customers = new Customers();
                this.cmbcustomer.DataSource = Customers.ObtenerTodosCustomer();//Tipo DataTable
                this.cmbcustomer.DisplayMember = "CustName";
                this.cmbcustomer.ValueMember = "Id";


                txtid.Text = Convert.ToString(nvoice.obteneridsiguiente());





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


                    nvoice.InsertQuery(Convert.ToInt32(txtid.Text),Convert.ToInt32(cmbcustomer.SelectedValue), Convert.ToInt32(txtQty.Text), Convert.ToDouble(txtprice.Text), Convert.ToDouble(txtitbis.Text), Convert.ToDouble(txtsubtotal.Text), Convert.ToDouble(txttotal.Text));

                    MessageBox.Show("Registro Agregado");


                }
                if (operacion == 2)
                {
                    nvoice.UpdateQuery(Convert.ToInt32(txtid.Text),Convert.ToInt32(txtid.Text), Convert.ToInt32(cmbcustomer.SelectedValue), Convert.ToInt32(txtQty.Text), Convert.ToDouble(txtprice.Text), Convert.ToDouble(txtitbis.Text), Convert.ToDouble(txtsubtotal.Text), Convert.ToDouble(txttotal.Text));

                    MessageBox.Show("Registro Modificado");
                }

                ActivarControles(false);


                actualizargrid();

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
        public void actualizargrid ()
        {
            InvoiceDetail invoiceD = new InvoiceDetail();
            tbldepartamentoDataGridView.DataSource = invoiceD.ObtenerTodosRegistro();
        }
        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                DialogResult Dialogo = MessageBox.Show("Esta seguro que desea Borrar este Registro",
                   "Borrarando Registro", MessageBoxButtons.YesNo);
                if (Dialogo == DialogResult.Yes)
                {
                   // InvoiceDetail.DeleteQuery(Convert.ToInt32(txtid.Text));

                    MessageBox.Show("Registro Eliminado Correctamente", "", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                    actualizargrid();

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
            txtid.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["Id"].Value);
            cmbcustomer.SelectedValue = Convert.ToInt32(tbldepartamentoDataGridView.CurrentRow.Cells["CustomerId"].Value);
            txtitbis.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["Qty"].Value);
            txtQty.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["Price"].Value);
            txtprice.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["TotalItbis"].Value);
            txtsubtotal.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["SubTotal"].Value);
            txttotal.Text = Convert.ToString(tbldepartamentoDataGridView.CurrentRow.Cells["Total"].Value);





            
        }
    }
}

