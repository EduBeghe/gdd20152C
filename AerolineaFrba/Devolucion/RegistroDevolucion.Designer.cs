namespace AerolineaFrba.Devolucion
{
    partial class RegistroDevolucion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnr = new System.Windows.Forms.TextBox();
            this.motivo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.devolucionDe = new System.Windows.Forms.ComboBox();
            this.codigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Compra o PNR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo de Pasaje y/o Encomienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motivo de Cancelacion";
            // 
            // pnr
            // 
            this.pnr.Location = new System.Drawing.Point(279, 94);
            this.pnr.Name = "pnr";
            this.pnr.Size = new System.Drawing.Size(200, 26);
            this.pnr.TabIndex = 6;
            this.pnr.TextChanged += new System.EventHandler(this.pnr_TextChanged);
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(279, 196);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(200, 62);
            this.motivo.TabIndex = 8;
            this.motivo.Text = "";
            this.motivo.TextChanged += new System.EventHandler(this.motivo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Devolucion de :";
            // 
            // devolucionDe
            // 
            this.devolucionDe.FormattingEnabled = true;
            this.devolucionDe.Location = new System.Drawing.Point(279, 54);
            this.devolucionDe.Name = "devolucionDe";
            this.devolucionDe.Size = new System.Drawing.Size(200, 28);
            this.devolucionDe.TabIndex = 11;
            this.devolucionDe.SelectedIndexChanged += new System.EventHandler(this.devolucionDe_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.FormattingEnabled = true;
            this.codigo.Location = new System.Drawing.Point(279, 133);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(200, 28);
            this.codigo.TabIndex = 12;
            // 
            // RegistroDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 354);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.devolucionDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.pnr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroDevolucion";
            this.Text = "Devolución Pasajes o Encomiendas";
            this.Load += new System.EventHandler(this.RegistroDevolucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pnr;
        private System.Windows.Forms.RichTextBox motivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox devolucionDe;
        private System.Windows.Forms.ComboBox codigo;
    }
}