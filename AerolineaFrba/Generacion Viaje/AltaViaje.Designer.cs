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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.llegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rutasAereasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aeronave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Salida";
            // 
            // ruta
            // 
            this.ruta.FormattingEnabled = true;
            this.ruta.Location = new System.Drawing.Point(232, 75);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(376, 28);
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
            this.aeronave.Location = new System.Drawing.Point(232, 117);
            this.aeronave.Name = "aeronave";
            this.aeronave.Size = new System.Drawing.Size(376, 28);
            this.aeronave.TabIndex = 5;
            this.aeronave.ValueMember = "Cod_Aeronave";
            this.aeronave.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // salida
            // 
            this.salida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.salida.Location = new System.Drawing.Point(232, 163);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(376, 26);
            this.salida.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de Llegada estimada";
            // 
            // llegada
            // 
            this.llegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.llegada.Location = new System.Drawing.Point(232, 205);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(376, 26);
            this.llegada.TabIndex = 9;
            // 
            // llegadaEstimada
            // 
            this.llegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.llegadaEstimada.Location = new System.Drawing.Point(232, 246);
            this.llegadaEstimada.Name = "llegadaEstimada";
            this.llegadaEstimada.Size = new System.Drawing.Size(376, 26);
            this.llegadaEstimada.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(592, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.llegadaEstimada);
            this.Controls.Add(this.llegada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.aeronave);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker llegada;
        private System.Windows.Forms.DateTimePicker llegadaEstimada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rutasAereasBindingSource;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
    }
}