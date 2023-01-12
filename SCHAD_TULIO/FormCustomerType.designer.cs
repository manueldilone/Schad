namespace SCHAD_TULIO
{
    partial class FormCustomerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codDptoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbldepartamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.CodDpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.btagregar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            codDptoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
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
            codDptoLabel.Size = new System.Drawing.Size(55, 13);
            codDptoLabel.TabIndex = 32;
            codDptoLabel.Text = "Cod Dpto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(79, 22);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 34;
            descripcionLabel.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codDptoTextBox);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(codDptoLabel);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 71);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // codDptoTextBox
            // 
            this.codDptoTextBox.Location = new System.Drawing.Point(17, 38);
            this.codDptoTextBox.Name = "codDptoTextBox";
            this.codDptoTextBox.Size = new System.Drawing.Size(52, 20);
            this.codDptoTextBox.TabIndex = 36;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(75, 38);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(588, 20);
            this.descripcionTextBox.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbldepartamentoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 391);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // tbldepartamentoDataGridView
            // 
            this.tbldepartamentoDataGridView.AllowUserToAddRows = false;
            this.tbldepartamentoDataGridView.AllowUserToDeleteRows = false;
            this.tbldepartamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbldepartamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDpto,
            this.Descripcion});
            this.tbldepartamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbldepartamentoDataGridView.Location = new System.Drawing.Point(3, 16);
            this.tbldepartamentoDataGridView.Name = "tbldepartamentoDataGridView";
            this.tbldepartamentoDataGridView.ReadOnly = true;
            this.tbldepartamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbldepartamentoDataGridView.Size = new System.Drawing.Size(666, 372);
            this.tbldepartamentoDataGridView.TabIndex = 32;
            this.tbldepartamentoDataGridView.Click += new System.EventHandler(this.tbldepartamentoDataGridView_Click);
            // 
            // CodDpto
            // 
            this.CodDpto.DataPropertyName = "CodDpto";
            this.CodDpto.FillWeight = 75F;
            this.CodDpto.HeaderText = "Código";
            this.CodDpto.Name = "CodDpto";
            this.CodDpto.ReadOnly = true;
            this.CodDpto.Width = 75;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descipción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            this.groupBox5.Size = new System.Drawing.Size(669, 82);
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
            this.btsalir.Location = new System.Drawing.Point(530, 19);
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
            // FormCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCHAD_TULIO.Properties.Resources.chrome_bottom_left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Type";
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
        private System.Windows.Forms.TextBox codDptoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}