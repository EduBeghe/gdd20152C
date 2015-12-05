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
            

            
            if (origenRuta != null && destinoRuta != null ) new RutaAereaRepository().modificarCiudades( 
                ruta, 
                ( Ciudad ) origenRuta.SelectedItem, 
                ( Ciudad ) destinoRuta.SelectedItem );
            if (servicioRuta != null) new RutaAereaRepository().modificarTipoServicio(ruta, ( TipoServicio ) servicioRuta.SelectedItem);
            if (costoKgRuta != null && costoPasajeRuta != null) new RutaAereaRepository().modificarPrecio(
                ruta, 
                Convert.ToInt32(costoKgRuta), 
                Convert.ToInt32(costoPasajeRuta ));
            MessageBox.Show("Ruta modificada con exito");
            // recargar info ? 
        }

        private void ModificarRuta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet5.Tipos_De_Servicios' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet4.Tipos_De_Servicios' Puede moverla o quitarla según sea necesario.
            

        }
    }
}
