namespace AerolineaFrba.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.estadistica = new System.Windows.Forms.ComboBox();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.NumericUpDown();
            this.dataGridEstadistica = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la estadística a consultar:";
            // 
            // estadistica
            // 
            this.estadistica.FormattingEnabled = true;
            this.estadistica.Items.AddRange(new object[] {
            "Destinos con más pasajes comprados",
            "Destinos con más aeronaves vacías",
            "Clientes con mayoría de millas acumuladas",
            "Destinos de los pasajes mas cancelados",
            "Aeronaves con mayor cantidad de días  fuera de servicio"});
            this.estadistica.Location = new System.Drawing.Point(12, 36);
            this.estadistica.Name = "estadistica";
            this.estadistica.Size = new System.Drawing.Size(489, 21);
            this.estadistica.TabIndex = 1;
            // 
            // semestre
            // 
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre"});
            this.semestre.Location = new System.Drawing.Point(12, 98);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(158, 21);
            this.semestre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione el año:";
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(343, 99);
            this.anio.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.anio.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(158, 20);
            this.anio.TabIndex = 6;
            this.anio.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // dataGridEstadistica
            // 
            this.dataGridEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadistica.Location = new System.Drawing.Point(12, 156);
            this.dataGridEstadistica.Name = "dataGridEstadistica";
            this.dataGridEstadistica.Size = new System.Drawing.Size(489, 150);
            this.dataGridEstadistica.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridEstadistica);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.estadistica);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadistica;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown anio;
        private System.Windows.Forms.DataGridView dataGridEstadistica;
        private System.Windows.Forms.Button button1;

    }
}