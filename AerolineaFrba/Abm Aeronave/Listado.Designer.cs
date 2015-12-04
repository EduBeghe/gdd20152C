namespace AerolineaFrba.Abm_Ciudad
{
    partial class ListadoAeronave
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
            this.label5 = new System.Windows.Forms.Label();
            this.aeronavesGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gD2C2015DataSet1 = new AerolineaFrba.GD2C2015DataSet1();
            this.fabricantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricantesTableAdapter = new AerolineaFrba.GD2C2015DataSet1TableAdapters.FabricantesTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSet2 = new AerolineaFrba.GD2C2015DataSet2();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavesTableAdapter = new AerolineaFrba.GD2C2015DataSet2TableAdapters.AeronavesTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.gD2C2015DataSet3 = new AerolineaFrba.GD2C2015DataSet3();
            this.aeronavesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavesTableAdapter1 = new AerolineaFrba.GD2C2015DataSet3TableAdapters.AeronavesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtro 4";
            // 
            // aeronavesGrid
            // 
            this.aeronavesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeronavesGrid.Location = new System.Drawing.Point(8, 128);
            this.aeronavesGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aeronavesGrid.Name = "aeronavesGrid";
            this.aeronavesGrid.RowTemplate.Height = 28;
            this.aeronavesGrid.Size = new System.Drawing.Size(350, 170);
            this.aeronavesGrid.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fabricantesBindingSource;
            this.comboBox1.DisplayMember = "Nombre_Fabricante";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Nombre_Fabricante";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 302);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "Baja Por Vida Util";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 302);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 21);
            this.button4.TabIndex = 12;
            this.button4.Text = "Baja Por Problemas Tecnicos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 302);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 21);
            this.button5.TabIndex = 13;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gD2C2015DataSet1
            // 
            this.gD2C2015DataSet1.DataSetName = "GD2C2015DataSet1";
            this.gD2C2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricantesBindingSource
            // 
            this.fabricantesBindingSource.DataMember = "Fabricantes";
            this.fabricantesBindingSource.DataSource = this.gD2C2015DataSet1;
            // 
            // fabricantesTableAdapter
            // 
            this.fabricantesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.aeronavesBindingSource;
            this.comboBox2.DisplayMember = "Matricula";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "Matricula";
            // 
            // gD2C2015DataSet2
            // 
            this.gD2C2015DataSet2.DataSetName = "GD2C2015DataSet2";
            this.gD2C2015DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "Aeronaves";
            this.aeronavesBindingSource.DataSource = this.gD2C2015DataSet2;
            // 
            // aeronavesTableAdapter
            // 
            this.aeronavesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.aeronavesBindingSource1;
            this.comboBox3.DisplayMember = "Cod_Aeronave";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(100, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.ValueMember = "Cod_Aeronave";
            // 
            // gD2C2015DataSet3
            // 
            this.gD2C2015DataSet3.DataSetName = "GD2C2015DataSet3";
            this.gD2C2015DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeronavesBindingSource1
            // 
            this.aeronavesBindingSource1.DataMember = "Aeronaves";
            this.aeronavesBindingSource1.DataSource = this.gD2C2015DataSet3;
            // 
            // aeronavesTableAdapter1
            // 
            this.aeronavesTableAdapter1.ClearBeforeFill = true;
            // 
            // ListadoAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aeronavesGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListadoAeronave";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.ListadoAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView aeronavesGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private GD2C2015DataSet1 gD2C2015DataSet1;
        private System.Windows.Forms.BindingSource fabricantesBindingSource;
        private GD2C2015DataSet1TableAdapters.FabricantesTableAdapter fabricantesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private GD2C2015DataSet2 gD2C2015DataSet2;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private GD2C2015DataSet2TableAdapters.AeronavesTableAdapter aeronavesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private GD2C2015DataSet3 gD2C2015DataSet3;
        private System.Windows.Forms.BindingSource aeronavesBindingSource1;
        private GD2C2015DataSet3TableAdapters.AeronavesTableAdapter aeronavesTableAdapter1;
    }
}