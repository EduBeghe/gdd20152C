namespace AerolineaFrba.Abm_Ciudad
{
    partial class BajaPorProblemasTecnicos
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
            this.label2 = new System.Windows.Forms.Label();
            this.fechaProblemasTecnicos = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reemplazarCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Reinicio de Servicio";
            // 
            // fechaProblemasTecnicos
            // 
            this.fechaProblemasTecnicos.Location = new System.Drawing.Point(179, 29);
            this.fechaProblemasTecnicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaProblemasTecnicos.Name = "fechaProblemasTecnicos";
            this.fechaProblemasTecnicos.Size = new System.Drawing.Size(135, 20);
            this.fechaProblemasTecnicos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baja por Problemas Tecnicos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dar de baja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reemplazarCheckbox
            // 
            this.reemplazarCheckbox.AutoSize = true;
            this.reemplazarCheckbox.Location = new System.Drawing.Point(11, 51);
            this.reemplazarCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reemplazarCheckbox.Name = "reemplazarCheckbox";
            this.reemplazarCheckbox.Size = new System.Drawing.Size(184, 17);
            this.reemplazarCheckbox.TabIndex = 6;
            this.reemplazarCheckbox.Text = "Reemplazar la Aeronave por otra ";
            this.reemplazarCheckbox.UseVisualStyleBackColor = true;
            // 
            // BajaPorProblemasTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 102);
            this.Controls.Add(this.reemplazarCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaProblemasTecnicos);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BajaPorProblemasTecnicos";
            this.Text = "Probelmas Tecnicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaProblemasTecnicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox reemplazarCheckbox;
    }
}