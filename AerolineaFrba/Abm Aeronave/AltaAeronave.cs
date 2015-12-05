using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Repositories;
using AerolineaFrba.Domain;


namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        public AltaAeronave()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cargar los datos de los inputs box
            new AeronaveRepository().darDeAlta(
                new Aeronave( 
                Convert.ToInt32( codigoAeronave.Text ),
                Convert.ToInt32( matriculaAeronave.Text),
                fechaAltaAeronave.Value,
                ( Fabricante ) fabricanteAeronave.SelectedItem,
                modeloAeronave.Text,
                ( TipoServicio ) tipoServicio.SelectedItem,
                Convert.ToInt32( kgAeronave ),
                Convert.ToInt32( butacasPasillo) + Convert.ToInt32( butacasVentanilla )
                ));
        }

        private void AltaAeronave_Load(object sender, EventArgs e)
        {
            BindingSource servicioSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
            this.tipoServicio.DataSource = servicioSource;
            BindingSource fabricanteSource = new BindingSource(new BindingList<Fabricante>(new FabricantesRepository().getFabricantes()), null);
            this.fabricanteAeronave.DataSource = fabricanteSource;


        }
    }
}
