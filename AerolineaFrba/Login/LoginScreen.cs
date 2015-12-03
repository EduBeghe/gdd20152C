﻿using System;
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
            new UsuarioRepository().login(usuarioTextbox.Text, passwordTextbox.Text);
        }

    }
}
