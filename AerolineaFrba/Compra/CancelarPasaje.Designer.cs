namespace AerolineaFrba.Compra
{
    partial class CancelarPasaje
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pasajesGrid = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pasajesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancelar Pasaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(85, 41);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 26);
            this.fecha.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasajesGrid
            // 
            this.pasajesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajesGrid.Location = new System.Drawing.Point(12, 177);
            this.pasajesGrid.Name = "pasajesGrid";
            this.pasajesGrid.RowTemplate.Height = 28;
            this.pasajesGrid.Size = new System.Drawing.Size(503, 150);
            this.pasajesGrid.TabIndex = 7;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(12, 333);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(503, 30);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar Pasaje";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Motivo ( cambiar por un textBox mejor ) ";
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(304, 78);
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(100, 26);
            this.motivo.TabIndex = 10;
            // 
            // CancelarPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 375);
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.pasajesGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CancelarPasaje";
            this.Text = "CancelarPasaje";
            ((System.ComponentModel.ISupportInitialize)(this.pasajesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView pasajesGrid;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox motivo;
    }
}