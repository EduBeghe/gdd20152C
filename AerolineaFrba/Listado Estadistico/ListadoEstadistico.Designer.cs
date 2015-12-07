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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.estadistica = new System.Windows.Forms.ComboBox();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.gD2C2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridEstadistica = new System.Windows.Forms.DataGridView();
            this.listadoEstadisticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoEstadisticoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEstadisticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEstadisticoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
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
            this.estadistica.Location = new System.Drawing.Point(18, 55);
            this.estadistica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estadistica.Name = "estadistica";
            this.estadistica.Size = new System.Drawing.Size(732, 28);
            this.estadistica.TabIndex = 1;
            // 
            // semestre
            // 
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre"});
            this.semestre.Location = new System.Drawing.Point(18, 147);
            this.semestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(232, 28);
            this.semestre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione el año:";
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(281, 149);
            this.anio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.anio.Size = new System.Drawing.Size(220, 26);
            this.anio.TabIndex = 6;
            this.anio.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(915, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridEstadistica
            // 
            this.dataGridEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstadistica.Location = new System.Drawing.Point(12, 204);
            this.dataGridEstadistica.Name = "dataGridEstadistica";
            this.dataGridEstadistica.RowTemplate.Height = 28;
            this.dataGridEstadistica.Size = new System.Drawing.Size(1154, 270);
            this.dataGridEstadistica.TabIndex = 9;
            // 
            // listadoEstadisticoBindingSource
            // 
            this.listadoEstadisticoBindingSource.DataSource = typeof(AerolineaFrba.Listado_Estadistico.ListadoEstadistico);
            // 
            // listadoEstadisticoBindingSource1
            // 
            this.listadoEstadisticoBindingSource1.DataSource = typeof(AerolineaFrba.Listado_Estadistico.ListadoEstadistico);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 486);
            this.Controls.Add(this.dataGridEstadistica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.estadistica);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEstadisticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoEstadisticoBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource gD2C2015DataSetBindingSource;
        private System.Windows.Forms.BindingSource listadoEstadisticoBindingSource;
        private System.Windows.Forms.BindingSource listadoEstadisticoBindingSource1;
        private System.Windows.Forms.DataGridView dataGridEstadistica;

    }
}