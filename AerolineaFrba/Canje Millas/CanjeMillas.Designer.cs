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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Canje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto Elegido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(219, 32);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(200, 26);
            this.dni.TabIndex = 4;
            // 
            // producto
            // 
            this.producto.FormattingEnabled = true;
            this.producto.Location = new System.Drawing.Point(219, 99);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(200, 28);
            this.producto.TabIndex = 5;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(219, 135);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(200, 26);
            this.cantidad.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar Canje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(219, 64);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(200, 26);
            this.apellido.TabIndex = 11;
            // 
            // canjeMillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 218);
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
            this.Name = "canjeMillas";
            this.Text = "Form1";
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
    }
}