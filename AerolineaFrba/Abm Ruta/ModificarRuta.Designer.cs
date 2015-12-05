namespace AerolineaFrba.Abm_Ruta
{
    partial class ModificarRuta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.origenRuta = new System.Windows.Forms.ComboBox();
            this.destinoRuta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costoKgRuta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codigoRuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costoPasajeRuta = new System.Windows.Forms.TextBox();
            this.servicioRuta = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposDeServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Servicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // origenRuta
            // 
            this.origenRuta.DataSource = this.ciudadesBindingSource;
            this.origenRuta.DisplayMember = "Nombre_Ciudad";
            this.origenRuta.FormattingEnabled = true;
            this.origenRuta.Location = new System.Drawing.Point(115, 47);
            this.origenRuta.Margin = new System.Windows.Forms.Padding(2);
            this.origenRuta.Name = "origenRuta";
            this.origenRuta.Size = new System.Drawing.Size(107, 21);
            this.origenRuta.TabIndex = 8;
            this.origenRuta.ValueMember = "Nombre_Ciudad";
            // 
            // destinoRuta
            // 
            this.destinoRuta.DataSource = this.ciudadesBindingSource;
            this.destinoRuta.DisplayMember = "Nombre_Ciudad";
            this.destinoRuta.FormattingEnabled = true;
            this.destinoRuta.Location = new System.Drawing.Point(115, 75);
            this.destinoRuta.Margin = new System.Windows.Forms.Padding(2);
            this.destinoRuta.Name = "destinoRuta";
            this.destinoRuta.Size = new System.Drawing.Size(107, 21);
            this.destinoRuta.TabIndex = 9;
            this.destinoRuta.ValueMember = "Nombre_Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo Base por KG";
            // 
            // costoKgRuta
            // 
            this.costoKgRuta.Location = new System.Drawing.Point(169, 106);
            this.costoKgRuta.Margin = new System.Windows.Forms.Padding(2);
            this.costoKgRuta.Name = "costoKgRuta";
            this.costoKgRuta.Size = new System.Drawing.Size(52, 20);
            this.costoKgRuta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo";
            // 
            // codigoRuta
            // 
            this.codigoRuta.Location = new System.Drawing.Point(115, 21);
            this.codigoRuta.Margin = new System.Windows.Forms.Padding(2);
            this.codigoRuta.Name = "codigoRuta";
            this.codigoRuta.Size = new System.Drawing.Size(107, 20);
            this.codigoRuta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Costo Base por Pasaje";
            // 
            // costoPasajeRuta
            // 
            this.costoPasajeRuta.Location = new System.Drawing.Point(169, 128);
            this.costoPasajeRuta.Margin = new System.Windows.Forms.Padding(2);
            this.costoPasajeRuta.Name = "costoPasajeRuta";
            this.costoPasajeRuta.Size = new System.Drawing.Size(52, 20);
            this.costoPasajeRuta.TabIndex = 15;
            // 
            // servicioRuta
            // 
            this.servicioRuta.DataSource = this.tiposDeServiciosBindingSource;
            this.servicioRuta.DisplayMember = "Descripcion_Servicio";
            this.servicioRuta.FormattingEnabled = true;
            this.servicioRuta.Location = new System.Drawing.Point(115, 156);
            this.servicioRuta.Margin = new System.Windows.Forms.Padding(2);
            this.servicioRuta.Name = "servicioRuta";
            this.servicioRuta.Size = new System.Drawing.Size(107, 21);
            this.servicioRuta.TabIndex = 16;
            this.servicioRuta.ValueMember = "Descripcion_Servicio";
            // 
            // gD2C2015DataSet
            // 
            // 
            // gD2C2015DataSetBindingSource
            // 
            this.gD2C2015DataSetBindingSource.Position = 0;
            // 
            // gD2C2015DataSet4
            // 
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            // 
            // ciudadesTableAdapter
            // 
            // 
            // gD2C2015DataSet5
            // 
            // 
            // tiposDeServiciosBindingSource
            // 
            this.tiposDeServiciosBindingSource.DataMember = "Tipos_De_Servicios";
            // 
            // tipos_De_ServiciosTableAdapter
            // 
            // 
            // ModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 254);
            this.Controls.Add(this.servicioRuta);
            this.Controls.Add(this.costoPasajeRuta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codigoRuta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.costoKgRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destinoRuta);
            this.Controls.Add(this.origenRuta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarRuta";
            this.Text = "Modificar Rutas";
            this.Load += new System.EventHandler(this.ModificarRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox origenRuta;
        private System.Windows.Forms.ComboBox destinoRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costoKgRuta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigoRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costoPasajeRuta;
        private System.Windows.Forms.ComboBox servicioRuta;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private System.Windows.Forms.BindingSource tiposDeServiciosBindingSource;
        
    }
}