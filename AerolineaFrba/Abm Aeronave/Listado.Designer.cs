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
            this.fabricantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fabricante = new System.Windows.Forms.ComboBox();
            this.servicio = new System.Windows.Forms.ComboBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Servicio";
            // 
            // aeronavesGrid
            // 
            this.aeronavesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aeronavesGrid.Location = new System.Drawing.Point(9, 197);
            this.aeronavesGrid.Name = "aeronavesGrid";
            this.aeronavesGrid.ReadOnly = true;
            this.aeronavesGrid.RowTemplate.Height = 28;
            this.aeronavesGrid.Size = new System.Drawing.Size(914, 262);
            this.aeronavesGrid.TabIndex = 7;
            // 
            // fabricantesBindingSource
            // 
            this.fabricantesBindingSource.DataMember = "Fabricantes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(848, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Baja Por Vida Util";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "Baja Por Problemas Tecnicos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(596, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(327, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "Aeronaves";
            // 
            // aeronavesBindingSource1
            // 
            this.aeronavesBindingSource1.DataMember = "Aeronaves";
            // 
            // fabricante
            // 
            this.fabricante.DataSource = this.fabricantesBindingSource;
            this.fabricante.FormattingEnabled = true;
            this.fabricante.Location = new System.Drawing.Point(612, 44);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(309, 28);
            this.fabricante.TabIndex = 16;
            // 
            // servicio
            // 
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(612, 107);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(309, 28);
            this.servicio.TabIndex = 17;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(139, 52);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(304, 26);
            this.codigo.TabIndex = 18;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(139, 112);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(304, 26);
            this.matricula.TabIndex = 19;
            // 
            // ListadoAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 509);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aeronavesGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListadoAeronave";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.ListadoAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource fabricantesBindingSource;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private System.Windows.Forms.BindingSource aeronavesBindingSource1;
        private System.Windows.Forms.ComboBox fabricante;
        private System.Windows.Forms.ComboBox servicio;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox matricula;
    }
}