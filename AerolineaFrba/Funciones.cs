using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Domain;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Aeronave;

namespace AerolineaFrba
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void AltaAeronaveButton_Click(object sender, EventArgs e)
        {
            new AltaAeronave.ShowDialog();
        }

       
    }
}
