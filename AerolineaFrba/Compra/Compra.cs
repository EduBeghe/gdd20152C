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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet4.Ciudades);

        }
    }
}
