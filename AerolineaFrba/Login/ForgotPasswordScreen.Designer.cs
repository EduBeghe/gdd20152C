namespace PagoElectronico.UI.Login
{
    partial class ForgotPasswordScreen
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
            this.buscarPreguntaButton = new System.Windows.Forms.Button();
            this.respuestaButton = new System.Windows.Forms.Button();
            this.respuestaTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.PreguntaSecreta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscarPreguntaButton
            // 
            this.buscarPreguntaButton.Location = new System.Drawing.Point(292, 37);
            this.buscarPreguntaButton.Name = "buscarPreguntaButton";
            this.buscarPreguntaButton.Size = new System.Drawing.Size(117, 23);
            this.buscarPreguntaButton.TabIndex = 11;
            this.buscarPreguntaButton.Text = "Buscar Pregunta";
            this.buscarPreguntaButton.UseVisualStyleBackColor = true;
            // 
            // respuestaButton
            // 
            this.respuestaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.respuestaButton.Location = new System.Drawing.Point(90, 140);
            this.respuestaButton.Name = "respuestaButton";
            this.respuestaButton.Size = new System.Drawing.Size(204, 23);
            this.respuestaButton.TabIndex = 10;
            this.respuestaButton.Text = "Login";
            this.respuestaButton.UseVisualStyleBackColor = true;
            // 
            // respuestaTextbox
            // 
            this.respuestaTextbox.Location = new System.Drawing.Point(121, 103);
            this.respuestaTextbox.Name = "respuestaTextbox";
            this.respuestaTextbox.Size = new System.Drawing.Size(229, 20);
            this.respuestaTextbox.TabIndex = 9;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(90, 37);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameTextbox.Size = new System.Drawing.Size(157, 20);
            this.usernameTextbox.TabIndex = 8;
            // 
            // PreguntaSecreta
            // 
            this.PreguntaSecreta.AutoSize = true;
            this.PreguntaSecreta.Location = new System.Drawing.Point(12, 103);
            this.PreguntaSecreta.Name = "PreguntaSecreta";
            this.PreguntaSecreta.Size = new System.Drawing.Size(87, 13);
            this.PreguntaSecreta.TabIndex = 7;
            this.PreguntaSecreta.Text = "PreguntaSecreta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // ForgotPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 187);
            this.Controls.Add(this.buscarPreguntaButton);
            this.Controls.Add(this.respuestaButton);
            this.Controls.Add(this.respuestaTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.PreguntaSecreta);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPasswordScreen";
            this.Text = "ForgotPasswordScreen";
            this.Load += new System.EventHandler(this.ForgotPasswordScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarPreguntaButton;
        private System.Windows.Forms.Button respuestaButton;
        private System.Windows.Forms.TextBox respuestaTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label PreguntaSecreta;
        private System.Windows.Forms.Label label1;
    }
}