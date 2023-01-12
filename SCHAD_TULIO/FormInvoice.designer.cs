namespace SCHAD_TULIO
{
    partial class FormInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label codDptoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtitbis = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbldepartamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btagregar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codDptoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbldepartamentoDataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // codDptoLabel
            // 
            codDptoLabel.AutoSize = true;
            codDptoLabel.Location = new System.Drawing.Point(14, 22);
            codDptoLabel.Name = "codDptoLabel";
            codDptoLabel.Size = new System.Drawing.Size(19, 13);
            codDptoLabel.TabIndex = 32;
            codDptoLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(79, 22);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(54, 13);
            descripcionLabel.TabIndex = 34;
            descripcionLabel.Text = "Customer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(392, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(26, 13);
            label2.TabIndex = 41;
            label2.Text = "Qty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(498, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 50;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(585, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 13);
            label4.TabIndex = 51;
            label4.Text = "TotalItbis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(679, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 13);
            label5.TabIndex = 52;
            label5.Text = "SubTotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(773, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 13);
            label6.TabIndex = 53;
            label6.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtsubtotal);
            this.groupBox1.Controls.Add(this.txtitbis);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cmbcustomer);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(codDptoLabel);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txttotal.Location = new System.Drawing.Point(747, 38);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(86, 20);
            this.txttotal.TabIndex = 49;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtsubtotal.Location = new System.Drawing.Point(655, 38);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(86, 20);
            this.txtsubtotal.TabIndex = 48;
            // 
            // txtitbis
            // 
            this.txtitbis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtitbis.Location = new System.Drawing.Point(563, 38);
            this.txtitbis.Name = "txtitbis";
            this.txtitbis.ReadOnly = true;
            this.txtitbis.Size = new System.Drawing.Size(86, 20);
            this.txtitbis.TabIndex = 47;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(471, 38);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(86, 20);
            this.txtprice.TabIndex = 46;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(379, 38);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(86, 20);
            this.txtQty.TabIndex = 45;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(75, 38);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(298, 21);
            this.cmbcustomer.TabIndex = 43;
            this.cmbcustomer.Click += new System.EventHandler(this.cmbcustomer_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(17, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 20);
            this.txtid.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbldepartamentoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 388);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // tbldepartamentoDataGridView
            // 
            this.tbldepartamentoDataGridView.AllowUserToAddRows = false;
            this.tbldepartamentoDataGridView.AllowUserToDeleteRows = false;
            this.tbldepartamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbldepartamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodCliente,
            this.CustomerId,
            this.Qty,
            this.Price,
            this.TotalItbis,
            this.SubTotal,
            this.Total});
            this.tbldepartamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbldepartamentoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbldepartamentoDataGridView.Name = "tbldepartamentoDataGridView";
            this.tbldepartamentoDataGridView.ReadOnly = true;
            this.tbldepartamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbldepartamentoDataGridView.Size = new System.Drawing.Size(863, 369);
            this.tbldepartamentoDataGridView.TabIndex = 32;
            this.tbldepartamentoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbldepartamentoDataGridView_CellFormatting);
            this.tbldepartamentoDataGridView.Click += new System.EventHandler(this.tbldepartamentoDataGridView_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.btcancelar);
            this.groupBox5.Controls.Add(this.btsalir);
            this.groupBox5.Controls.Add(this.bteditar);
            this.groupBox5.Controls.Add(this.btagregar);
            this.groupBox5.Controls.Add(this.btguardar);
            this.groupBox5.Location = new System.Drawing.Point(12, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(869, 82);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = global::SCHAD_TULIO.Properties.Resources.cancel;
            this.button2.Location = new System.Drawing.Point(437, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Image = global::SCHAD_TULIO.Properties.Resources.rechazar;
            this.btcancelar.Location = new System.Drawing.Point(344, 19);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(87, 57);
            this.btcancelar.TabIndex = 6;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btsalir
            // 
            this.btsalir.Image = ((System.Drawing.Image)(resources.GetObject("btsalir.Image")));
            this.btsalir.Location = new System.Drawing.Point(776, 19);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(87, 57);
            this.btsalir.TabIndex = 5;
            this.btsalir.Text = "Salir";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // bteditar
            // 
            this.bteditar.Image = global::SCHAD_TULIO.Properties.Resources.applic_f;
            this.bteditar.Location = new System.Drawing.Point(158, 19);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(87, 57);
            this.bteditar.TabIndex = 2;
            this.bteditar.Text = "Editar";
            this.bteditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btagregar
            // 
            this.btagregar.Image = global::SCHAD_TULIO.Properties.Resources.applic;
            this.btagregar.Location = new System.Drawing.Point(65, 19);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(87, 57);
            this.btagregar.TabIndex = 1;
            this.btagregar.Text = "Nuevo";
            this.btagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Image = global::SCHAD_TULIO.Properties.Resources.sdfsd;
            this.btguardar.Location = new System.Drawing.Point(251, 19);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(87, 57);
            this.btguardar.TabIndex = 3;
            this.btguardar.Text = "Guardar";
            this.btguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 75F;
            this.Id.HeaderText = "Código";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // CodCliente
            // 
            this.CodCliente.DataPropertyName = "CodCliente";
            this.CodCliente.HeaderText = "Customers";
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Customers";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalItbis
            // 
            this.TotalItbis.DataPropertyName = "TotalItbis";
            this.TotalItbis.HeaderText = "TotalItbis";
            this.TotalItbis.Name = "TotalItbis";
            this.TotalItbis.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCHAD_TULIO.Properties.Resources.chrome_bottom_left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.DEPARTAMENTOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbldepartamentoDataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView tbldepartamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtitbis;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}