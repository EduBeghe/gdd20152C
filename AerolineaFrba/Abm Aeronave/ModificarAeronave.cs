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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ModificarAeronave : Form
    {
        private Aeronave aeronave;

        public ModificarAeronave()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Aeronave aeronave)
        {
            this.aeronave = Aeronave.Copy(aeronave);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var retorno = 0;
                if (rehabilitar.Checked)
                {
                    retorno = new AeronaveRepository().modificarAeronave(
                        aeronave.Cod_Aeronave,
                        Convert.ToDateTime(fechaAlta.Value),
                        (Fabricante)fabricanteAeronave.SelectedItem,
                        modelo.Text,
                        (TipoServicio)tipoServicio.SelectedItem,
                        true);
                }
                else {
                    retorno = new AeronaveRepository().modificarAeronave(
                        aeronave.Cod_Aeronave,
                        Convert.ToDateTime(fechaAlta.Value),
                        (Fabricante)fabricanteAeronave.SelectedItem,
                        modelo.Text,
                        (TipoServicio)tipoServicio.SelectedItem,
                        false);
                }
                if (retorno == 0)
                {
                    MessageBox.Show("Modificacion de Aeronave exitosa");
                }
                else
                {
                    MessageBox.Show("No se cumplieron los dias fuera de servicio de la aeronave");
                }
                this.Close();
               } else { MessageBox.Show("Debe llenar todos los campos"); }
                    
        }

        private void ModificarAeronave_Load(object sender, EventArgs e)
        {
            BindingSource servicioSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
            this.tipoServicio.DataSource = servicioSource;
            BindingSource fabricanteSource = new BindingSource(new BindingList<Fabricante>(new FabricantesRepository().getFabricantes()), null);
            this.fabricanteAeronave.DataSource = fabricanteSource;
        }
    }
}

