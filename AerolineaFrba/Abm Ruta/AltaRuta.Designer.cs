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
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costoKg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costoPasaje = new System.Windows.Forms.TextBox();
            this.servicio = new System.Windows.Forms.ComboBox();
            this.tiposDeServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Servicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
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
            this.origen.Location = new System.Drawing.Point(172, 71);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(158, 28);
            this.origen.TabIndex = 8;
            this.origen.ValueMember = "Nombre_Ciudad";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            // 
            // gD2C2015DataSet4
            // 
            // 
            // destino
            // 
            this.destino.DataSource = this.ciudadesBindingSource;
            this.destino.DisplayMember = "Nombre_Ciudad";
            this.destino.FormattingEnabled = true;
            this.destino.Location = new System.Drawing.Point(172, 115);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(158, 28);
            this.destino.TabIndex = 9;
            this.destino.ValueMember = "Nombre_Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo Base por KG";
            // 
            // costoKg
            // 
            this.costoKg.Location = new System.Drawing.Point(254, 163);
            this.costoKg.Name = "costoKg";
            this.costoKg.Size = new System.Drawing.Size(76, 26);
            this.costoKg.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(172, 32);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(158, 26);
            this.codigo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Costo Base por Pasaje";
            // 
            // costoPasaje
            // 
            this.costoPasaje.Location = new System.Drawing.Point(254, 197);
            this.costoPasaje.Name = "costoPasaje";
            this.costoPasaje.Size = new System.Drawing.Size(76, 26);
            this.costoPasaje.TabIndex = 15;
            // 
            // servicio
            // 
            this.servicio.DataSource = this.tiposDeServiciosBindingSource;
            this.servicio.DisplayMember = "Descripcion_Servicio";
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(172, 237);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(158, 28);
            this.servicio.TabIndex = 16;
            this.servicio.ValueMember = "Descripcion_Servicio";
            // 
            // tiposDeServiciosBindingSource
            // 
            this.tiposDeServiciosBindingSource.DataMember = "Tipos_De_Servicios";
            // 
            // gD2C2015DataSet5
            // 
            // 
            // ciudadesTableAdapter
            // 
            // 
            // tipos_De_ServiciosTableAdapter
            // 
            // 
            // AltaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 391);
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
            this.Name = "AltaRuta";
            this.Text = "Alta Ruta";
            this.Load += new System.EventHandler(this.AltaRuta_Load);
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
        private System.Windows.Forms.ComboBox origen;
        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costoKg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costoPasaje;
        private System.Windows.Forms.ComboBox servicio;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private System.Windows.Forms.BindingSource tiposDeServiciosBindingSource;
     }
}