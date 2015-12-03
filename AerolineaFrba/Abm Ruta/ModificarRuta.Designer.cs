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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 248);
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
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // origenRuta
            // 
            this.origenRuta.FormattingEnabled = true;
            this.origenRuta.Location = new System.Drawing.Point(172, 72);
            this.origenRuta.Name = "origenRuta";
            this.origenRuta.Size = new System.Drawing.Size(158, 28);
            this.origenRuta.TabIndex = 8;
            // 
            // destinoRuta
            // 
            this.destinoRuta.FormattingEnabled = true;
            this.destinoRuta.Location = new System.Drawing.Point(172, 116);
            this.destinoRuta.Name = "destinoRuta";
            this.destinoRuta.Size = new System.Drawing.Size(158, 28);
            this.destinoRuta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo Base por KG";
            // 
            // costoKgRuta
            // 
            this.costoKgRuta.Location = new System.Drawing.Point(254, 163);
            this.costoKgRuta.Name = "costoKgRuta";
            this.costoKgRuta.Size = new System.Drawing.Size(76, 26);
            this.costoKgRuta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codigo";
            // 
            // codigoRuta
            // 
            this.codigoRuta.Location = new System.Drawing.Point(172, 32);
            this.codigoRuta.Name = "codigoRuta";
            this.codigoRuta.Size = new System.Drawing.Size(158, 26);
            this.codigoRuta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Costo Base por Pasaje";
            // 
            // costoPasajeRuta
            // 
            this.costoPasajeRuta.Location = new System.Drawing.Point(254, 197);
            this.costoPasajeRuta.Name = "costoPasajeRuta";
            this.costoPasajeRuta.Size = new System.Drawing.Size(76, 26);
            this.costoPasajeRuta.TabIndex = 15;
            // 
            // servicioRuta
            // 
            this.servicioRuta.FormattingEnabled = true;
            this.servicioRuta.Location = new System.Drawing.Point(172, 240);
            this.servicioRuta.Name = "servicioRuta";
            this.servicioRuta.Size = new System.Drawing.Size(158, 28);
            this.servicioRuta.TabIndex = 16;
            // 
            // ModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 391);
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
            this.Name = "ModificarRuta";
            this.Text = "Form1";
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
    }
}