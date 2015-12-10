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
using AerolineaFrba.Utils;


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
            if (Validacion.validarInputs( this.Controls ) && 
                Validacion.soloNumeros( this.kgAeronave, kgAeronave.Name ) &&
                Validacion.soloNumeros( this.butacasPasillo, butacasPasillo.Name ) &&
                    Validacion.soloNumeros( this.butacasVentanilla, butacasVentanilla.Name )
            ) 

            {
                int retorno = new AeronaveRepository().darDeAlta(
                    matriculaAeronave.Text,
                    fechaAltaAeronave.Value,
                    (Fabricante)fabricanteAeronave.SelectedItem,
                    (Modelo) modelo.SelectedItem,
                    (TipoServicio)tipoServicio.SelectedItem,
                    Convert.ToInt32(kgAeronave.Text),
                    Convert.ToInt32(butacasPasillo.Text),
                    Convert.ToInt32(butacasVentanilla.Text)
                    );
                if (retorno == 0)
                {
                    MessageBox.Show("Aeronave exitosamente dada de Alta");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La aeronave que quiere dar de alta ya existe");
                }
                
            }
        }

        private void AltaAeronave_Load(object sender, EventArgs e)
        {
            BindingSource servicioSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
            this.tipoServicio.DataSource = servicioSource;
            BindingSource fabricanteSource = new BindingSource(new BindingList<Fabricante>(new FabricantesRepository().getFabricantes()), null);
            this.fabricanteAeronave.DataSource = fabricanteSource;
            BindingSource modelosSource = new BindingSource(new BindingList<Modelo>(new ModeloRepository().getModelos()), null);
            this.modelo.DataSource = modelosSource;


        }

       

    }
}
