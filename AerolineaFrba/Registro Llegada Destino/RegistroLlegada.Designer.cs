namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class RegistroLlegada
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
            this.matricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.matriculaComboBox = new System.Windows.Forms.ComboBox();
            this.aeronavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salida = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arribo = new System.Windows.Forms.ComboBox();
            this.horario = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Location = new System.Drawing.Point(60, 57);
            this.matricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(187, 20);
            this.matricula.TabIndex = 0;
            this.matricula.Text = "Matricula de la Aeronave:";
            this.matricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad de salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad de arribo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Llegada:";
            // 
            // matriculaComboBox
            // 
            this.matriculaComboBox.FormattingEnabled = true;
            this.matriculaComboBox.Location = new System.Drawing.Point(276, 52);
            this.matriculaComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matriculaComboBox.Name = "matriculaComboBox";
            this.matriculaComboBox.Size = new System.Drawing.Size(298, 28);
            this.matriculaComboBox.TabIndex = 7;
            // 
            // aeronavesBindingSource
            // 
            this.aeronavesBindingSource.DataMember = "Aeronaves";
            // 
            // salida
            // 
            this.salida.FormattingEnabled = true;
            this.salida.Location = new System.Drawing.Point(276, 108);
            this.salida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(298, 28);
            this.salida.TabIndex = 8;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            // 
            // arribo
            // 
            this.arribo.FormattingEnabled = true;
            this.arribo.Location = new System.Drawing.Point(276, 168);
            this.arribo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arribo.Name = "arribo";
            this.arribo.Size = new System.Drawing.Size(298, 28);
            this.arribo.TabIndex = 9;
            // 
            // horario
            // 
            this.horario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horario.Location = new System.Drawing.Point(276, 226);
            this.horario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(298, 26);
            this.horario.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(512, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrar llegada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.arribo);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.matriculaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matricula);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistroLlegada";
            this.Text = "Registrar Llegada de Aeronave";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeronavesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox matriculaComboBox;
        private System.Windows.Forms.ComboBox salida;
        private System.Windows.Forms.ComboBox arribo;
        private System.Windows.Forms.DateTimePicker horario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource aeronavesBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
    }
}