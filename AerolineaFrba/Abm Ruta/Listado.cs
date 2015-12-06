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
using AerolineaFrba.Abm_Ruta;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoRuta : Form
    {
        public ListadoRuta()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.rutasGrid.DataSource = new BindingSource(new BindingList<RutaAerea>(new RutaAereaRepository().findRuta()), null); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ruta = (RutaAerea)rutasGrid.SelectedRows[0].DataBoundItem;
            new RutaAereaRepository().darDeBaja( ruta ) ;
            MessageBox.Show("Ruta dada de baja con exito");
            this.rutasGrid.DataSource = new BindingSource(new BindingList<RutaAerea>(new RutaAereaRepository().findRuta()), null); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ModificarRuta().ShowDialog( (RutaAerea)rutasGrid.SelectedRows[0].DataBoundItem);
        }

        private void destino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoRuta_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.servicio.DataSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
        }
    }
}
