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
            var repo = new UsuarioRepository();            
            var valido = repo.ValidarLogin(usuarioTextbox.Text, passwordTextbox.Text);
            if (valido == 1)
            {
                repo.iniciarSesion(usuarioTextbox.Text);
                MessageBox.Show("Bienvenido " + CLC_SessionManager.currentUser.Usuario_Nombre, "Login exitoso");
                this.Close();
            }
            else if (valido == -1) {
                MessageBox.Show("Se dio de baja su usuario por exceder la cantidad de intentos de logueo");
            }else MessageBox.Show("Datos Incorrectos");
            
        }

    }
}
