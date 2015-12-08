namespace AerolineaFrba.Abm_Ciudad
{
    partial class ModificarAeronave
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.tipoServicio = new System.Windows.Forms.ComboBox();
            this.rehabilitar = new System.Windows.Forms.CheckBox();
            this.fabricanteAeronave = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Aeronaves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fabricante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de Servicio";
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(190, 68);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(100, 26);
            this.modelo.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha de Alta";
            // 
            // fechaAlta
            // 
            this.fechaAlta.Location = new System.Drawing.Point(392, 178);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(200, 26);
            this.fechaAlta.TabIndex = 24;
            // 
            // tipoServicio
            // 
            this.tipoServicio.FormattingEnabled = true;
            this.tipoServicio.Location = new System.Drawing.Point(462, 127);
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Size = new System.Drawing.Size(130, 28);
            this.tipoServicio.TabIndex = 29;
            // 
            // rehabilitar
            // 
            this.rehabilitar.AutoSize = true;
            this.rehabilitar.Location = new System.Drawing.Point(29, 129);
            this.rehabilitar.Name = "rehabilitar";
            this.rehabilitar.Size = new System.Drawing.Size(111, 24);
            this.rehabilitar.TabIndex = 30;
            this.rehabilitar.Text = "Rehabilitar";
            this.rehabilitar.UseVisualStyleBackColor = true;
            // 
            // fabricanteAeronave
            // 
            this.fabricanteAeronave.FormattingEnabled = true;
            this.fabricanteAeronave.Location = new System.Drawing.Point(462, 66);
            this.fabricanteAeronave.Name = "fabricanteAeronave";
            this.fabricanteAeronave.Size = new System.Drawing.Size(130, 28);
            this.fabricanteAeronave.TabIndex = 31;
            // 
            // ModificarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 284);
            this.Controls.Add(this.fabricanteAeronave);
            this.Controls.Add(this.rehabilitar);
            this.Controls.Add(this.tipoServicio);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAeronave";
            this.Text = "Modificar Aeronave";
            this.Load += new System.EventHandler(this.ModificarAeronave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.ComboBox tipoServicio;
        private System.Windows.Forms.CheckBox rehabilitar;
        private System.Windows.Forms.ComboBox fabricanteAeronave;
    }
}