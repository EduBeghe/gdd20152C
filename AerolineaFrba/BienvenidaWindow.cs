using System;
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
            new Funciones().ShowDialog(this);
            this.Close();
        }

        private void BienvenidaWindow_Load(object sender, EventArgs e)
        {

        }
        
    }
}
