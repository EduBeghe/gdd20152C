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
            if (Validacion.validarInputs(this.Controls)
                && Validacion.soloNumeros( this.kgs, "Kgs para encomienda" ))
            {
                var retorno = 0;
                if (rehabilitar.Checked)
                {
                    retorno = new AeronaveRepository().modificarAeronave(
                        matricula.Text,
                        aeronave.Cod_Aeronave,
                        (Fabricante)fabricanteAeronave.SelectedItem,
                        (Modelo) modelo.SelectedItem,
                        (TipoServicio)tipoServicio.SelectedItem,
                        true,
                        Convert.ToInt32( kgs.Text )
                        );
                }
                else {
                    retorno = new AeronaveRepository().modificarAeronave(
                        matricula.Text,
                        aeronave.Cod_Aeronave,
                        (Fabricante)fabricanteAeronave.SelectedItem,
                        (Modelo) modelo.SelectedItem,
                        (TipoServicio)tipoServicio.SelectedItem,
                        false,
                        Convert.ToInt32(kgs.Text)
                        );
                }
                if (retorno == 0) MessageBox.Show("Modificacion de Aeronave exitosa");
                else if (retorno == -1) MessageBox.Show("La matricula ingrsada ya existe");
                else if (retorno == -2) MessageBox.Show("La aeronave tiene viajes asignados");
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
            this.cantidadPasillo.Text = DBAdapter.executeProcedureWithReturnValue("Get_Butacas_Por_Tipo", aeronave.Cod_Aeronave, "Pasillo").ToString();
            this.cantidadVentanilla.Text = DBAdapter.executeProcedureWithReturnValue("Get_Butacas_Por_Tipo", aeronave.Cod_Aeronave, "Ventanilla").ToString();
            BindingSource modeloSource = new BindingSource(new BindingList<Modelo>(new ModeloRepository().getModelos()), null);
            this.modelo.DataSource = modeloSource;
        }

        private void sumarVentanilla_Click(object sender, EventArgs e)
        {
            this.cantidadVentanilla.Text = (Convert.ToInt32(this.cantidadVentanilla.Text) + 1).ToString();
            DBAdapter.executeProcedure("Modificar_Agregar_Butaca", aeronave.Cod_Aeronave, "Ventanilla");
        }

        private void sumarPasillo_Click(object sender, EventArgs e)
        {
            this.cantidadPasillo.Text = (Convert.ToInt32(this.cantidadPasillo.Text) + 1).ToString();
            DBAdapter.executeProcedure("Modificar_Agregar_Butaca", aeronave.Cod_Aeronave, "Pasillo");
        }

        private void restarVentanilla_Click(object sender, EventArgs e)
        {
            this.cantidadVentanilla.Text = (Convert.ToInt32(this.cantidadVentanilla.Text) -1 ).ToString();
            DBAdapter.executeProcedure("Modificar_Quitar_Butaca", aeronave.Cod_Aeronave, "Ventanilla");
        }

        private void restarPasillo_Click(object sender, EventArgs e)
        {
            this.cantidadPasillo.Text = (Convert.ToInt32(this.cantidadPasillo.Text) - 1).ToString();
            DBAdapter.executeProcedure("Modificar_Quitar_Butaca", aeronave.Cod_Aeronave, "Pasillo");
        }
    }
}

