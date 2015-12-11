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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ModificarRuta : Form
    {
        int retornoServicio;
        int retornoPrecio;
        int retornoCiudades;

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
            if (origen.SelectedItem != null && destino.SelectedItem != null)
            {
                retornoCiudades = new RutaAereaRepository().modificarCiudades(
                    ruta,
                    (Ciudad)origen.SelectedItem,
                    (Ciudad)destino.SelectedItem);
            }
            if (servicio.SelectedItem != null)
            {
                retornoServicio = new RutaAereaRepository().modificarTipoServicio(ruta, (TipoServicio)servicio.SelectedItem);
            }
            if (costoKgRuta.Text != "" && costoPasajeRuta.Text != "")
            {
                if (Validacion.soloNumeros(costoKgRuta, costoKgRuta.Name) && Validacion.soloNumeros(costoPasajeRuta, costoPasajeRuta.Name))
                {
                    retornoPrecio = new RutaAereaRepository().modificarPrecio(
                    ruta,
                    Convert.ToInt32(costoKgRuta.Text),
                    Convert.ToInt32(costoPasajeRuta.Text));
                }
            }

            if (retornoPrecio == -1) MessageBox.Show("Fallo la modificacion, la ruta tiene viajes asigandos");    
            if (retornoCiudades != -1 && retornoPrecio != -1 && retornoServicio != -1) MessageBox.Show("Ruta modificada con exito");    
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
