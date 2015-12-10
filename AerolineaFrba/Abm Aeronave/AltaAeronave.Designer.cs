namespace AerolineaFrba.Abm_Aeronave
{
    partial class AltaAeronave
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaAltaAeronave = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.matriculaAeronave = new System.Windows.Forms.TextBox();
            this.kgAeronave = new System.Windows.Forms.TextBox();
            this.butacasPasillo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.butacasVentanilla = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoServicio = new System.Windows.Forms.ComboBox();
            this.tiposDeServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricanteAeronave = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta De Aeronaves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Alta";
            // 
            // fechaAltaAeronave
            // 
            this.fechaAltaAeronave.Location = new System.Drawing.Point(190, 74);
            this.fechaAltaAeronave.Name = "fechaAltaAeronave";
            this.fechaAltaAeronave.Size = new System.Drawing.Size(200, 26);
            this.fechaAltaAeronave.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Matricula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cantidad de butacas Pasillo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad de Kg ";
            // 
            // matriculaAeronave
            // 
            this.matriculaAeronave.Location = new System.Drawing.Point(126, 128);
            this.matriculaAeronave.Name = "matriculaAeronave";
            this.matriculaAeronave.Size = new System.Drawing.Size(181, 26);
            this.matriculaAeronave.TabIndex = 13;
            // 
            // kgAeronave
            // 
            this.kgAeronave.Location = new System.Drawing.Point(494, 222);
            this.kgAeronave.Name = "kgAeronave";
            this.kgAeronave.Size = new System.Drawing.Size(100, 26);
            this.kgAeronave.TabIndex = 14;
            // 
            // butacasPasillo
            // 
            this.butacasPasillo.Location = new System.Drawing.Point(256, 312);
            this.butacasPasillo.Name = "butacasPasillo";
            this.butacasPasillo.Size = new System.Drawing.Size(48, 26);
            this.butacasPasillo.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad de butacas Ventanilla";
            // 
            // butacasVentanilla
            // 
            this.butacasVentanilla.Location = new System.Drawing.Point(546, 314);
            this.butacasVentanilla.Name = "butacasVentanilla";
            this.butacasVentanilla.Size = new System.Drawing.Size(48, 26);
            this.butacasVentanilla.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tipo de Servicio";
            // 
            // tipoServicio
            // 
            this.tipoServicio.DataSource = this.tiposDeServiciosBindingSource;
            this.tipoServicio.DisplayMember = "Descripcion_Servicio";
            this.tipoServicio.FormattingEnabled = true;
            this.tipoServicio.Location = new System.Drawing.Point(453, 158);
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Size = new System.Drawing.Size(140, 28);
            this.tipoServicio.TabIndex = 28;
            this.tipoServicio.ValueMember = "Descripcion_Servicio";
            // 
            // tiposDeServiciosBindingSource
            // 
            this.tiposDeServiciosBindingSource.DataMember = "Tipos_De_Servicios";
            // 
            // fabricanteAeronave
            // 
            this.fabricanteAeronave.DataSource = this.gD2C2015DataSetBindingSource;
            this.fabricanteAeronave.FormattingEnabled = true;
            this.fabricanteAeronave.Location = new System.Drawing.Point(126, 248);
            this.fabricanteAeronave.Name = "fabricanteAeronave";
            this.fabricanteAeronave.Size = new System.Drawing.Size(181, 28);
            this.fabricanteAeronave.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fabricante";
            // 
            // modelo
            // 
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(126, 184);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(181, 28);
            this.modelo.TabIndex = 31;
            // 
            // AltaAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 497);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fabricanteAeronave);
            this.Controls.Add(this.tipoServicio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.butacasVentanilla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butacasPasillo);
            this.Controls.Add(this.kgAeronave);
            this.Controls.Add(this.matriculaAeronave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fechaAltaAeronave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaAeronave";
            this.Text = "Alta Aeronaves";
            this.Load += new System.EventHandler(this.AltaAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaAltaAeronave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox matriculaAeronave;
        private System.Windows.Forms.TextBox kgAeronave;
        private System.Windows.Forms.TextBox butacasPasillo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox butacasVentanilla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipoServicio;
        private System.Windows.Forms.ComboBox fabricanteAeronave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private System.Windows.Forms.BindingSource tiposDeServiciosBindingSource;
        private System.Windows.Forms.ComboBox modelo;
    }
}