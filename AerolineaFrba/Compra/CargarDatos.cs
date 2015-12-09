using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class CargarDatos : Form
    {
        int codAeronave;
        int butaca;

        public CargarDatos()
        {
            InitializeComponent();
        }
        
        internal void ShowDialog(object codAeronave, int butaca)
        {
            this.codAeronave = Convert.ToInt32(codAeronave);
            this.butaca = butaca;
            this.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
