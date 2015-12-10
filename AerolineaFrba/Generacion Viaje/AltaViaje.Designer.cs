namespace AerolineaFrba.Generacion_Viaje
{
    partial class AltaViaje
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
            this.ruta = new System.Windows.Forms.ComboBox();
            this.rutasAereasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronave = new System.Windows.Forms.ComboBox();
            this.salida = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.llegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rutasAereasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aeronave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Salida";
            // 
            // ruta
            // 
            this.ruta.FormattingEnabled = true;
            this.ruta.Location = new System.Drawing.Point(155, 49);
            this.ruta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(252, 21);
            this.ruta.TabIndex = 4;
            this.ruta.SelectedIndexChanged += new System.EventHandler(this.ruta_SelectedIndexChanged);
            // 
            // rutasAereasBindingSource
            // 
            this.rutasAereasBindingSource.DataMember = "RutasAereas";
            // 
            // aeronave
            // 
            this.aeronave.DisplayMember = "Cod_Aeronave";
            this.aeronave.FormattingEnabled = true;
            this.aeronave.Location = new System.Drawing.Point(155, 76);
            this.aeronave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aeronave.Name = "aeronave";
            this.aeronave.Size = new System.Drawing.Size(252, 21);
            this.aeronave.TabIndex = 5;
            this.aeronave.ValueMember = "Cod_Aeronave";
            this.aeronave.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // salida
            // 
            this.salida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.salida.Location = new System.Drawing.Point(155, 106);
            this.salida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(252, 20);
            this.salida.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Llegada estimada";
            // 
            // llegadaEstimada
            // 
            this.llegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.llegadaEstimada.Location = new System.Drawing.Point(155, 139);
            this.llegadaEstimada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.llegadaEstimada.Name = "llegadaEstimada";
            this.llegadaEstimada.Size = new System.Drawing.Size(252, 20);
            this.llegadaEstimada.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.llegadaEstimada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.aeronave);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaViaje";
            this.Text = "Alta de Viajes";
            this.Load += new System.EventHandler(this.AltaViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutasAereasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ruta;
        private System.Windows.Forms.ComboBox aeronave;
        private System.Windows.Forms.DateTimePicker salida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker llegadaEstimada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rutasAereasBindingSource;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
    }
}