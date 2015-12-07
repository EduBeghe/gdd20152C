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
            if (Validacion.validarInputs(this.Controls))
            {
               var retorno = new RutaAereaRepository().darDeAlta(
                        (Ciudad)origen.SelectedItem,
                        (Ciudad)destino.SelectedItem,
                        (TipoServicio)servicio.SelectedItem,
                        Convert.ToInt32(costoKg.Text),
                        Convert.ToInt32(costoPasaje.Text)
                        //(bool)true // MIRAR! Agregar estado a la form 
                        );
               if (retorno == 0)
               {
                   MessageBox.Show("Ruta Aerea dada de alta exitosamente");
               }
               else
               {
                   MessageBox.Show("La ruta aerea que quiere dar de alta ya existe");
               }
            }
        }
        
        private void AltaRuta_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.servicio.DataSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
        }
    }
}
