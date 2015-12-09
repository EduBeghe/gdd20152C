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
using AerolineaFrba.Utils;

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
            Ciudad ciudadOrigen = ( Ciudad ) origen.SelectedItem;
            Ciudad ciudadDestino = (Ciudad) destino.SelectedItem;
            this.disponibilidad.DataSource = DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles", Convert.ToDateTime( fecha.Value ), ciudadOrigen.Nombre_Ciudad, ciudadDestino.Nombre_Ciudad );
            
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
        }
    }
}
