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
            this.origen = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costoKgRuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costoPasajeRuta = new System.Windows.Forms.TextBox();
            this.servicio = new System.Windows.Forms.ComboBox();
            this.tiposDeServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Servicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // origen
            // 
            this.origen.FormattingEnabled = true;
            this.origen.Location = new System.Drawing.Point(158, 42);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(158, 28);
            this.origen.TabIndex = 8;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            // 
            // destino
            // 
            this.destino.FormattingEnabled = true;
            this.destino.Location = new System.Drawing.Point(158, 85);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(158, 28);
            this.destino.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo Base por KG";
            // 
            // costoKgRuta
            // 
            this.costoKgRuta.Location = new System.Drawing.Point(240, 133);
            this.costoKgRuta.Name = "costoKgRuta";
            this.costoKgRuta.Size = new System.Drawing.Size(76, 26);
            this.costoKgRuta.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Costo Base por Pasaje";
            // 
            // costoPasajeRuta
            // 
            this.costoPasajeRuta.Location = new System.Drawing.Point(240, 167);
            this.costoPasajeRuta.Name = "costoPasajeRuta";
            this.costoPasajeRuta.Size = new System.Drawing.Size(76, 26);
            this.costoPasajeRuta.TabIndex = 15;
            // 
            // servicio
            // 
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(158, 210);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(158, 28);
            this.servicio.TabIndex = 16;
            // 
            // tiposDeServiciosBindingSource
            // 
            this.tiposDeServiciosBindingSource.DataMember = "Tipos_De_Servicios";
            // 
            // ModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.costoPasajeRuta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costoKgRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarRuta";
            this.Text = "Modificar Rutas";
            this.Load += new System.EventHandler(this.ModificarRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDeServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox costoKgRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costoPasajeRuta;
        private System.Windows.Forms.ComboBox servicio;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private System.Windows.Forms.BindingSource tiposDeServiciosBindingSource;
        
    }
}