using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AltaCiudad : Form
    {
        public AltaCiudad()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new CiudadRepository().darDeAlta( nombreCiudad.Text );
        }

        private void AltaCiudad_Load(object sender, EventArgs e)
        {

        }

        private void AltaCiudad_Load_1(object sender, EventArgs e)
        {

        }
    }
}
