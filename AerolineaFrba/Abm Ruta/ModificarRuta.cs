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
        public ModificarRuta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // recivir la ruta como parametro en algun lado

            // Ver si la opcion seleccionada es directamente el string o la entidad Ciudad ( lo mismo con el servicio 
            //if (ciudadOrigen != null && ciudadDestino != null ) new RutaAereaRepository().modificarCiudades( ruta, ciudadOrigen, ciudadDestino );
            //if (tipoServicio != null) new RutaAereaRepository().modificarTipoServicio(ruta, tipoServicio);
            MessageBox.Show("Ruta modificada con exito");

            // Recivo tmb la grid por parametro ?
            //this.rutasGrid.DataSource = new BindingSource(new BindingList<RutaAerea>(new RutaAereaRepository().findRuta()), null); 
        }
    }
}
