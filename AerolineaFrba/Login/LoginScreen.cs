using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Login
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        
        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            var valido = new UsuarioRepository().ValidarLogin(usuarioTextbox.Text, passwordTextbox.Text);
            if (valido > 0)
            {
                new UsuarioRepository().iniciarSesion(usuarioTextbox.Text);
                MessageBox.Show("Bienvenido " + CLC_SessionManager.currentUser.Usuario_Nombre, "Login exitoso");
            }
            else MessageBox.Show("Cuenta Bloqueada");
        }

    }
}
