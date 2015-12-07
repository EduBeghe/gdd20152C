namespace AerolineaFrba.Abm_Aeronave
{
    partial class Reemplazar
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
            this.reemplazarCheckbox = new System.Windows.Forms.CheckBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reemplazarCheckbox
            // 
            this.reemplazarCheckbox.AutoSize = true;
            this.reemplazarCheckbox.Location = new System.Drawing.Point(12, 29);
            this.reemplazarCheckbox.Name = "reemplazarCheckbox";
            this.reemplazarCheckbox.Size = new System.Drawing.Size(369, 24);
            this.reemplazarCheckbox.TabIndex = 0;
            this.reemplazarCheckbox.Text = "Reemplazar vuelos vendidos con otra aeronave";
            this.reemplazarCheckbox.UseVisualStyleBackColor = true;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(12, 59);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(369, 40);
            this.confirmar.TabIndex = 1;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // Reemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 111);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.reemplazarCheckbox);
            this.Name = "Reemplazar";
            this.Text = "Reemplazar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox reemplazarCheckbox;
        private System.Windows.Forms.Button confirmar;
    }
}