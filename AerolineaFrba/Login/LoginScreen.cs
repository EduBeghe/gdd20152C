using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AerolineaFrba.Utils;

namespace PagoElectronico.UI.Login
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgotPasswordScreen().ShowDialog();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void olvidoPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
