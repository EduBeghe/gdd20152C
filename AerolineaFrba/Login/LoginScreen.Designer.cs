namespace AerolineaFrba.Login
{
    partial class LoginScreen
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
            this.olvidoPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usuarioTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // olvidoPasswordLinkLabel
            // 
            this.olvidoPasswordLinkLabel.AutoSize = true;
            this.olvidoPasswordLinkLabel.Location = new System.Drawing.Point(230, 175);
            this.olvidoPasswordLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olvidoPasswordLinkLabel.Name = "olvidoPasswordLinkLabel";
            this.olvidoPasswordLinkLabel.Size = new System.Drawing.Size(161, 20);
            this.olvidoPasswordLinkLabel.TabIndex = 11;
            this.olvidoPasswordLinkLabel.TabStop = true;
            this.olvidoPasswordLinkLabel.Text = "Olvido su contrase;a?";
            this.olvidoPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.olvidoPasswordLinkLabel_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(74, 168);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(136, 23);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(18, 112);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 20);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Contraseña";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(45, 52);
            this.usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(64, 20);
            this.usuarioLabel.TabIndex = 8;
            this.usuarioLabel.Text = "Usuario";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(144, 108);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '●';
            this.passwordTextbox.Size = new System.Drawing.Size(228, 26);
            this.passwordTextbox.TabIndex = 7;
            // 
            // usuarioTextbox
            // 
            this.usuarioTextbox.Location = new System.Drawing.Point(144, 48);
            this.usuarioTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuarioTextbox.Name = "usuarioTextbox";
            this.usuarioTextbox.Size = new System.Drawing.Size(228, 26);
            this.usuarioTextbox.TabIndex = 6;
            this.usuarioTextbox.TextChanged += new System.EventHandler(this.usuarioTextbox_TextChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 242);
            this.Controls.Add(this.olvidoPasswordLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usuarioTextbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel olvidoPasswordLinkLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usuarioTextbox;
    }
}