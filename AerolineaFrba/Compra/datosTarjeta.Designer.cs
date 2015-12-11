namespace AerolineaFrba.Compra
{
    partial class datosTarjeta
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
            this.vencimiento = new System.Windows.Forms.DateTimePicker();
            this.codSeg = new System.Windows.Forms.TextBox();
            this.numeroTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoTarjeta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de la tarjeta";
            // 
            // vencimiento
            // 
            this.vencimiento.Location = new System.Drawing.Point(220, 153);
            this.vencimiento.Name = "vencimiento";
            this.vencimiento.Size = new System.Drawing.Size(200, 26);
            this.vencimiento.TabIndex = 2;
            // 
            // codSeg
            // 
            this.codSeg.Location = new System.Drawing.Point(220, 99);
            this.codSeg.Name = "codSeg";
            this.codSeg.Size = new System.Drawing.Size(200, 26);
            this.codSeg.TabIndex = 3;
            // 
            // numeroTarjeta
            // 
            this.numeroTarjeta.Location = new System.Drawing.Point(220, 47);
            this.numeroTarjeta.Name = "numeroTarjeta";
            this.numeroTarjeta.Size = new System.Drawing.Size(200, 26);
            this.numeroTarjeta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo de Seguridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // tipoTarjeta
            // 
            this.tipoTarjeta.FormattingEnabled = true;
            this.tipoTarjeta.Location = new System.Drawing.Point(220, 209);
            this.tipoTarjeta.Name = "tipoTarjeta";
            this.tipoTarjeta.Size = new System.Drawing.Size(200, 28);
            this.tipoTarjeta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de tarjeta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirmar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pagar en Efectivo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // datosTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipoTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroTarjeta);
            this.Controls.Add(this.codSeg);
            this.Controls.Add(this.vencimiento);
            this.Controls.Add(this.label1);
            this.Name = "datosTarjeta";
            this.Text = "datosTarjeta";
            this.Load += new System.EventHandler(this.datosTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker vencimiento;
        private System.Windows.Forms.TextBox codSeg;
        private System.Windows.Forms.TextBox numeroTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}