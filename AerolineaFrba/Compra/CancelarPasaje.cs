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
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Compra
{
    public partial class CancelarPasaje : Form
    {
        public CancelarPasaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // falta hacer find pasaje
            //this.pasajesGrid.DataSource = new BindingSource(new BindingList<Pasaje>(new PasajesRepository().findPasaje()), null); 
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            var pasaje = (Pasaje)pasajesGrid.SelectedRows[0].DataBoundItem;
            new PasajesRepository().cancelarPasaje( pasaje, fecha.Value, motivo.Text );
            MessageBox.Show("Pasaje cancelado con exito");
            //this.pasajesGrid.DataSource = new BindingSource(new BindingList<Pasaje>(new PasajesRepository().findPasaje()), null); 
        }
    }
}
