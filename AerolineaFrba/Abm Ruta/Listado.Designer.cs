namespace AerolineaFrba.Abm_Ciudad
{
    partial class ListadoRuta
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.origen = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rutasGrid = new System.Windows.Forms.DataGridView();
            this.destino = new System.Windows.Forms.ComboBox();
            this.servicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rutasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(117, 51);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(312, 26);
            this.codigo.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciudad Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ciudad Destino";
            // 
            // origen
            // 
            this.origen.FormattingEnabled = true;
            this.origen.Location = new System.Drawing.Point(609, 49);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(312, 28);
            this.origen.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(848, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(268, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Dar de Baja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(640, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(283, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rutasGrid
            // 
            this.rutasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutasGrid.Location = new System.Drawing.Point(12, 197);
            this.rutasGrid.Name = "rutasGrid";
            this.rutasGrid.RowTemplate.Height = 28;
            this.rutasGrid.Size = new System.Drawing.Size(911, 261);
            this.rutasGrid.TabIndex = 14;
            // 
            // destino
            // 
            this.destino.FormattingEnabled = true;
            this.destino.Location = new System.Drawing.Point(609, 112);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(312, 28);
            this.destino.TabIndex = 15;
            this.destino.SelectedIndexChanged += new System.EventHandler(this.destino_SelectedIndexChanged);
            // 
            // servicio
            // 
            this.servicio.FormattingEnabled = true;
            this.servicio.Location = new System.Drawing.Point(117, 112);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(312, 28);
            this.servicio.TabIndex = 16;
            // 
            // ListadoRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 509);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.rutasGrid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label1);
            this.Name = "ListadoRuta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rutasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox origen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView rutasGrid;
        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.ComboBox servicio;
    }
}