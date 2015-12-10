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
            this.tipoServicio = new System.Windows.Forms.ComboBox();
            this.fabricanteAeronave = new System.Windows.Forms.ComboBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadVentanilla = new System.Windows.Forms.Label();
            this.sumarVentanilla = new System.Windows.Forms.Button();
            this.restarVentanilla = new System.Windows.Forms.Button();
            this.restarPasillo = new System.Windows.Forms.Button();
            this.sumarPasillo = new System.Windows.Forms.Button();
            this.cantidadPasillo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelKgs = new System.Windows.Forms.Label();
            this.kgs = new System.Windows.Forms.TextBox();
            this.rehabilitar = new System.Windows.Forms.CheckBox();
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
            this.label6.Location = new System.Drawing.Point(315, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fabricante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 120);
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
            this.button1.Location = new System.Drawing.Point(246, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoServicio
            // 
            this.tipoServicio.FormattingEnabled = true;
            this.tipoServicio.Location = new System.Drawing.Point(462, 112);
            this.tipoServicio.Name = "tipoServicio";
            this.tipoServicio.Size = new System.Drawing.Size(130, 28);
            this.tipoServicio.TabIndex = 29;
            // 
            // fabricanteAeronave
            // 
            this.fabricanteAeronave.FormattingEnabled = true;
            this.fabricanteAeronave.Location = new System.Drawing.Point(462, 61);
            this.fabricanteAeronave.Name = "fabricanteAeronave";
            this.fabricanteAeronave.Size = new System.Drawing.Size(130, 28);
            this.fabricanteAeronave.TabIndex = 31;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(190, 114);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(100, 26);
            this.matricula.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cantidad de Butacas Ventanilla";
            // 
            // cantidadVentanilla
            // 
            this.cantidadVentanilla.AutoSize = true;
            this.cantidadVentanilla.Location = new System.Drawing.Point(25, 269);
            this.cantidadVentanilla.Name = "cantidadVentanilla";
            this.cantidadVentanilla.Size = new System.Drawing.Size(18, 20);
            this.cantidadVentanilla.TabIndex = 35;
            this.cantidadVentanilla.Text = "0";
            // 
            // sumarVentanilla
            // 
            this.sumarVentanilla.Location = new System.Drawing.Point(101, 256);
            this.sumarVentanilla.Name = "sumarVentanilla";
            this.sumarVentanilla.Size = new System.Drawing.Size(65, 33);
            this.sumarVentanilla.TabIndex = 36;
            this.sumarVentanilla.Text = "+";
            this.sumarVentanilla.UseVisualStyleBackColor = true;
            this.sumarVentanilla.Click += new System.EventHandler(this.sumarVentanilla_Click);
            // 
            // restarVentanilla
            // 
            this.restarVentanilla.Location = new System.Drawing.Point(192, 256);
            this.restarVentanilla.Name = "restarVentanilla";
            this.restarVentanilla.Size = new System.Drawing.Size(65, 33);
            this.restarVentanilla.TabIndex = 37;
            this.restarVentanilla.Text = "-";
            this.restarVentanilla.UseVisualStyleBackColor = true;
            this.restarVentanilla.Click += new System.EventHandler(this.restarVentanilla_Click);
            // 
            // restarPasillo
            // 
            this.restarPasillo.Location = new System.Drawing.Point(527, 259);
            this.restarPasillo.Name = "restarPasillo";
            this.restarPasillo.Size = new System.Drawing.Size(65, 33);
            this.restarPasillo.TabIndex = 41;
            this.restarPasillo.Text = "-";
            this.restarPasillo.UseVisualStyleBackColor = true;
            this.restarPasillo.Click += new System.EventHandler(this.restarPasillo_Click);
            // 
            // sumarPasillo
            // 
            this.sumarPasillo.Location = new System.Drawing.Point(436, 259);
            this.sumarPasillo.Name = "sumarPasillo";
            this.sumarPasillo.Size = new System.Drawing.Size(65, 33);
            this.sumarPasillo.TabIndex = 40;
            this.sumarPasillo.Text = "+";
            this.sumarPasillo.UseVisualStyleBackColor = true;
            this.sumarPasillo.Click += new System.EventHandler(this.sumarPasillo_Click);
            // 
            // cantidadPasillo
            // 
            this.cantidadPasillo.AutoSize = true;
            this.cantidadPasillo.Location = new System.Drawing.Point(360, 272);
            this.cantidadPasillo.Name = "cantidadPasillo";
            this.cantidadPasillo.Size = new System.Drawing.Size(18, 20);
            this.cantidadPasillo.TabIndex = 39;
            this.cantidadPasillo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cantidad de Butacas Pasillo";
            // 
            // labelKgs
            // 
            this.labelKgs.AutoSize = true;
            this.labelKgs.Location = new System.Drawing.Point(25, 164);
            this.labelKgs.Name = "labelKgs";
            this.labelKgs.Size = new System.Drawing.Size(163, 20);
            this.labelKgs.TabIndex = 42;
            this.labelKgs.Text = "Kgs para encomienda";
            // 
            // kgs
            // 
            this.kgs.Location = new System.Drawing.Point(224, 158);
            this.kgs.Name = "kgs";
            this.kgs.Size = new System.Drawing.Size(66, 26);
            this.kgs.TabIndex = 43;
            // 
            // rehabilitar
            // 
            this.rehabilitar.AutoSize = true;
            this.rehabilitar.Location = new System.Drawing.Point(319, 160);
            this.rehabilitar.Name = "rehabilitar";
            this.rehabilitar.Size = new System.Drawing.Size(111, 24);
            this.rehabilitar.TabIndex = 30;
            this.rehabilitar.Text = "Rehabilitar";
            this.rehabilitar.UseVisualStyleBackColor = true;
            // 
            // ModificarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 383);
            this.Controls.Add(this.kgs);
            this.Controls.Add(this.labelKgs);
            this.Controls.Add(this.restarPasillo);
            this.Controls.Add(this.sumarPasillo);
            this.Controls.Add(this.cantidadPasillo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.restarVentanilla);
            this.Controls.Add(this.sumarVentanilla);
            this.Controls.Add(this.cantidadVentanilla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fabricanteAeronave);
            this.Controls.Add(this.rehabilitar);
            this.Controls.Add(this.tipoServicio);
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
        private System.Windows.Forms.ComboBox tipoServicio;
        private System.Windows.Forms.ComboBox fabricanteAeronave;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cantidadVentanilla;
        private System.Windows.Forms.Button sumarVentanilla;
        private System.Windows.Forms.Button restarVentanilla;
        private System.Windows.Forms.Button restarPasillo;
        private System.Windows.Forms.Button sumarPasillo;
        private System.Windows.Forms.Label cantidadPasillo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelKgs;
        private System.Windows.Forms.TextBox kgs;
        private System.Windows.Forms.CheckBox rehabilitar;
    }
}