﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Login;


namespace AerolineaFrba
{
    public partial class BienvenidaWindow : Form
    {
        public BienvenidaWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form pantallaLogin = new LoginScreen();
            this.Hide();
            pantallaLogin.ShowDialog(this);
=======
            this.Hide();
            new Funciones().ShowDialog(this);
>>>>>>> 9b5872b0a06f4843d26081e8f0094810c0b1df20
            this.Close();
        }

        private void BienvenidaWindow_Load(object sender, EventArgs e)
        {

        }
        
    }
}
