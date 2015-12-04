namespace AerolineaFrba.Abm_Ruta
{
    partial class AltaRuta
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
            this.origen = new System.Windows.Forms.ComboBox();
            this.destino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costoKg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costoPasaje = new System.Windows.Forms.TextBox();
            this.servicio = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSet4 = new AerolineaFrba.GD2C2015DataSet4();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesTableAdapter = new AerolineaFrba.GD2C2015DataSet4TableAdapters.CiudadesTableAdapter();
            this.gD2C2015DataSet5 = new AerolineaFrba.GD2C2015DataSet5();
            this.tiposDeServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_De_ServiciosTableAdapter = new AerolineaFrba.GD2C2015DataSet5TableAdapters.Tipos_De_ServiciosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Ruta";
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
            this.label4.Location = new System.Drawing.Point(17, 159);
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
            this.button1.Text = "Dar de alta ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // origen
            // 
            this.origen.DataSource = this.ciudadesBindingSource;
            this.origen.DisplayMember = "Nombre_Ciudad";
            this.origen.FormattingEnabled = true;
            this.origen.Location = new System.Drawing.Point(115, 47);
            this.origen.Margin = new System.Windows.Forms.Padding(2);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(107, 21);
            this.origen.TabIndex = 8;
            this.origen.ValueMember = "Nombre_Ciudad";
            // 
            // destino
            // 
            this.destino.DataSource = this.ciudadesBindingSource;
            this.destino.DisplayMember = "Nombre_Ciudad";
            this.destino.FormattingEnabled = true;
            this.destino.Location = new System.Drawing.Point(115, 75);
            this.destino.Margin = new System.Windows.Forms.Padding(2);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(107, 21);
            this.destino.TabIndex = 9;
            this.destino.ValueMember = "Nombre_Ciudad";
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
            // costoKg
            // 
            this.costoKg.Location = new System.Drawing.Point(169, 106);
            this.costoKg.Margin = new System.Windows.Forms.Padding(2);
            this.costoKg.Name = "costoKg";
            this.costoKg.Size = new System.Drawing.Size(52, 20);
            this.costoKg.TabIndex = 11;
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
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(115, 21);
            this.codigo.Margin = new System.Windows.Forms.Padding(2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(107, 20);
            this.codigo.TabIndex = 13;
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
            // costoPasaje
            // 
            this.costoPasaje.Location = new System.Drawing.Point(169, 128);
            this.costoPasaje.Margin = new System.Windows.Forms.Padding(2);
            this.costoPasaje.Name = "costoPasaje";
            this.costoPasaje.Size = new System.Drawing.Size(52, 20);
            this.costoPasaje.TabIndex = 15;
            // 
            // servicio
            // 
            this.servicio.DataSource = this.tiposDeServiciosBindingSource;
            this.servicio.DisplayMember = "Descripcion_Servicio";
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(115, 154);
            this.servicio.Margin = new System.Windows.Forms.Padding(2);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(107, 21);
            this.servicio.TabIndex = 16;
            this.servicio.ValueMember = "Descripcion_Servicio";
            // 
            // gD2C2015DataSet4
            // 
            this.gD2C2015DataSet4.DataSetName = "GD2C2015DataSet4";
            this.gD2C2015DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.gD2C2015DataSet4;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // gD2C2015DataSet5
            // 
            this.gD2C2015DataSet5.DataSetName = "GD2C2015DataSet5";
            this.gD2C2015DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposDeServiciosBindingSource
            // 
            this.tiposDeServiciosBindingSource.DataMember = "Tipos_De_Servicios";
            this.tiposDeServiciosBindingSource.DataSource = this.gD2C2015DataSet5;
            // 
            // tipos_De_ServiciosTableAdapter
            // 
            this.tipos_De_ServiciosTableAdapter.ClearBeforeFill = true;
            // 
            // AltaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 254);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.costoPasaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.costoKg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaRuta";
            this.Text = "Alta Ruta";
            this.Load += new System.EventHandler(this.AltaRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet5)).EndInit();
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
        private System.Windows.Forms.ComboBox origen;
        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costoKg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costoPasaje;
        private System.Windows.Forms.ComboBox servicio;
        private GD2C2015DataSet4 gD2C2015DataSet4;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private GD2C2015DataSet4TableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private GD2C2015DataSet5 gD2C2015DataSet5;
        private System.Windows.Forms.BindingSource tiposDeServiciosBindingSource;
        private GD2C2015DataSet5TableAdapters.Tipos_De_ServiciosTableAdapter tipos_De_ServiciosTableAdapter;
     }
}