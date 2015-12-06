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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AltaRuta : Form
    {
        public AltaRuta()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new RutaAereaRepository().darDeAlta(
                new RutaAerea( 
                    Convert.ToInt32( codigo ),
                    ( Ciudad ) origen.SelectedItem,
                    ( Ciudad ) destino.SelectedItem,
                    ( TipoServicio ) servicio.SelectedItem,
                    Convert.ToInt32( costoKg ),
                    Convert.ToInt32( costoPasaje ),
                    ( bool ) true // MIRAR! Agregar estado a la form 
                    ));
        }
        
        private void AltaRuta_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.servicio.DataSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
        }
    }
}
