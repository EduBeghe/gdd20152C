namespace AerolineaFrba.Abm_Ciudad
{
    partial class ListadoButacas
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
            this.button3 = new System.Windows.Forms.Button();
            this.butacas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.butacas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Butacas Disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butacas
            // 
            this.butacas.AllowUserToAddRows = false;
            this.butacas.AllowUserToDeleteRows = false;
            this.butacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.butacas.Location = new System.Drawing.Point(12, 43);
            this.butacas.Name = "butacas";
            this.butacas.ReadOnly = true;
            this.butacas.RowTemplate.Height = 28;
            this.butacas.Size = new System.Drawing.Size(320, 334);
            this.butacas.TabIndex = 12;
            // 
            // ListadoButacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 427);
            this.Controls.Add(this.butacas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "ListadoButacas";
            this.Text = "Seleccion Butacas";
            this.Load += new System.EventHandler(this.ListadoButacas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.butacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView butacas;
    }
}