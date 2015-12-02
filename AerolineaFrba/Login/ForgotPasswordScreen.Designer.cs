namespace AerolineaFrba.Login
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
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

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
            this.buscarPreguntaButton.Location = new System.Drawing.Point(438, 57);
            this.buscarPreguntaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscarPreguntaButton.Name = "buscarPreguntaButton";
            this.buscarPreguntaButton.Size = new System.Drawing.Size(176, 35);
            this.buscarPreguntaButton.TabIndex = 11;
            this.buscarPreguntaButton.Text = "Buscar Pregunta";
            this.buscarPreguntaButton.UseVisualStyleBackColor = true;
            // 
            // respuestaButton
            // 
            this.respuestaButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.respuestaButton.Location = new System.Drawing.Point(135, 215);
            this.respuestaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.respuestaButton.Name = "respuestaButton";
            this.respuestaButton.Size = new System.Drawing.Size(306, 35);
            this.respuestaButton.TabIndex = 10;
            this.respuestaButton.Text = "Login";
            this.respuestaButton.UseVisualStyleBackColor = true;
            this.respuestaButton.Click += new System.EventHandler(this.respuestaButton_Click);
            // 
            // respuestaTextbox
            // 
            this.respuestaTextbox.Location = new System.Drawing.Point(182, 158);
            this.respuestaTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.respuestaTextbox.Name = "respuestaTextbox";
            this.respuestaTextbox.Size = new System.Drawing.Size(342, 26);
            this.respuestaTextbox.TabIndex = 9;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(135, 57);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameTextbox.Size = new System.Drawing.Size(234, 26);
            this.usernameTextbox.TabIndex = 8;
            // 
            // PreguntaSecreta
            // 
            this.PreguntaSecreta.AutoSize = true;
            this.PreguntaSecreta.Location = new System.Drawing.Point(18, 158);
            this.PreguntaSecreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreguntaSecreta.Name = "PreguntaSecreta";
            this.PreguntaSecreta.Size = new System.Drawing.Size(130, 20);
            this.PreguntaSecreta.TabIndex = 7;
            this.PreguntaSecreta.Text = "PreguntaSecreta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // ForgotPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 288);
            this.Controls.Add(this.buscarPreguntaButton);
            this.Controls.Add(this.respuestaButton);
            this.Controls.Add(this.respuestaTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.PreguntaSecreta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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