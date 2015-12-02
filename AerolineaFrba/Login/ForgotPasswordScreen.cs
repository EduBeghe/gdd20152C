using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Login
{
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        private void ForgotPasswordScreen_Load(object sender, EventArgs e)
        {
            this.respuestaTextbox.Enabled = false;
            this.respuestaButton.Enabled = false;
            this.buscarPreguntaButton.Focus();
        }

        private void repuestaButton_Click(object sender, EventArgs e)
        {

        }

        private void buscarPreguntaButton_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuestaButton_Click(object sender, EventArgs e)
        {

        }

    }
}
