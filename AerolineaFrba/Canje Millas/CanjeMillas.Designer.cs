namespace AerolineaFrba.Abm_Ciudad
{
    partial class canjeMillas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
           /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
           base.Dispose(disposing);
        }*/

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
            this.dni = new System.Windows.Forms.TextBox();
            this.producto = new System.Windows.Forms.ComboBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.gD2C2015DataSet6 = new AerolineaFrba.GD2C2015DataSet6();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new AerolineaFrba.GD2C2015DataSet6TableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Canje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto Elegido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(146, 21);
            this.dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(135, 20);
            this.dni.TabIndex = 4;
            // 
            // producto
            // 
            this.producto.DataSource = this.productosBindingSource;
            this.producto.DisplayMember = "Descripcion_Producto";
            this.producto.FormattingEnabled = true;
            this.producto.Location = new System.Drawing.Point(146, 64);
            this.producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(135, 21);
            this.producto.TabIndex = 5;
            this.producto.ValueMember = "Descripcion_Producto";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(146, 88);
            this.cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(135, 20);
            this.cantidad.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar Canje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(146, 42);
            this.apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(135, 20);
            this.apellido.TabIndex = 11;
            // 
            // gD2C2015DataSet6
            // 
            this.gD2C2015DataSet6.DataSetName = "GD2C2015DataSet6";
            this.gD2C2015DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gD2C2015DataSet6;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // canjeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 142);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "canjeMillas";
            this.Text = "Canje Millas";
            this.Load += new System.EventHandler(this.canjeMillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2015DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.ComboBox producto;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apellido;
        private GD2C2015DataSet6 gD2C2015DataSet6;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GD2C2015DataSet6TableAdapters.ProductosTableAdapter productosTableAdapter;
    }
}