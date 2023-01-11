using System;

namespace SCHAD_TULIO
{
    partial class loguin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loguin));
            this.txt2 = new System.Windows.Forms.TextBox();
            this.sitioweb = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Btsalir = new System.Windows.Forms.Button();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.cmbusuarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(72, 114);
            this.txt2.Name = "txt2";
            this.txt2.PasswordChar = '*';
            this.txt2.Size = new System.Drawing.Size(347, 20);
            this.txt2.TabIndex = 44;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // sitioweb
            // 
            this.sitioweb.AutoSize = true;
            this.sitioweb.BackColor = System.Drawing.Color.Transparent;
            this.sitioweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitioweb.ForeColor = System.Drawing.Color.Black;
            this.sitioweb.Location = new System.Drawing.Point(3, 9);
            this.sitioweb.Name = "sitioweb";
            this.sitioweb.Size = new System.Drawing.Size(535, 25);
            this.sitioweb.TabIndex = 41;
            this.sitioweb.Text = "Prueba de Habilidad de Desarrollo Windows Form";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(5, 117);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(69, 13);
            this.txtpassword.TabIndex = 40;
            this.txtpassword.Text = "Password :";
            // 
            // txtusuario
            // 
            this.txtusuario.AutoSize = true;
            this.txtusuario.BackColor = System.Drawing.Color.Transparent;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(16, 90);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(58, 13);
            this.txtusuario.TabIndex = 39;
            this.txtusuario.Text = "Usuario :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "http://www.schad.com";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SCHAD_TULIO.Properties.Resources.pfwnpmqobduovuykonec;
            this.pictureBox3.Location = new System.Drawing.Point(424, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // Btsalir
            // 
            this.Btsalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btsalir.Image = ((System.Drawing.Image)(resources.GetObject("Btsalir.Image")));
            this.Btsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btsalir.Location = new System.Drawing.Point(241, 142);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(89, 50);
            this.Btsalir.TabIndex = 38;
            this.Btsalir.Text = "Salir";
            this.Btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btsalir.UseVisualStyleBackColor = false;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // BtEntrar
            // 
            this.BtEntrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntrar.Image = ((System.Drawing.Image)(resources.GetObject("BtEntrar.Image")));
            this.BtEntrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtEntrar.Location = new System.Drawing.Point(118, 142);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(89, 50);
            this.BtEntrar.TabIndex = 37;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEntrar.UseVisualStyleBackColor = false;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // cmbusuarios
            // 
            this.cmbusuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbusuarios.FormattingEnabled = true;
            this.cmbusuarios.Location = new System.Drawing.Point(72, 87);
            this.cmbusuarios.Name = "cmbusuarios";
            this.cmbusuarios.Size = new System.Drawing.Size(347, 21);
            this.cmbusuarios.TabIndex = 47;
            this.cmbusuarios.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "@Todos los Derechos Reservados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(209, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "-Schad-";
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SCHAD_TULIO.Properties.Resources.chrome_bottom_left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 224);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbusuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.sitioweb);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.Btsalir);
            this.Controls.Add(this.BtEntrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese sus datos ";
            this.Load += new System.EventHandler(this.loguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt2;
        internal System.Windows.Forms.Label sitioweb;
        internal System.Windows.Forms.Label txtpassword;
        internal System.Windows.Forms.Label txtusuario;
        internal System.Windows.Forms.Button Btsalir;
        internal System.Windows.Forms.Button BtEntrar;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbusuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label label4;
      
    }
}

