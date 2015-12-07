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
    public partial class ModificarRuta : Form
    {
        private RutaAerea ruta;

        public ModificarRuta()
        {
            InitializeComponent();
        }

        internal void ShowDialog(RutaAerea ruta)
        {
            this.ruta = RutaAerea.Copy(ruta);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if ( todos en null ) falla 
            // If elementos no selected
                //if (origen != null && destino != null ) new RutaAereaRepository().modificarCiudades( 
                    //ruta, 
                    //( Ciudad ) origen.SelectedItem, 
                    //( Ciudad ) destino.SelectedItem );
            //if (servicio != null) new RutaAereaRepository().modificarTipoServicio(ruta, ( TipoServicio ) servicio.SelectedItem);
            if ( costoKgRuta.Text != "" && costoPasajeRuta.Text != "" ) new RutaAereaRepository().modificarPrecio(
                ruta, 
                Convert.ToInt32(costoKgRuta), 
                Convert.ToInt32(costoPasajeRuta ));
            MessageBox.Show("Ruta modificada con exito");
            this.Close();
        }

        private void ModificarRuta_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.servicio.DataSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
        }
    }
}
