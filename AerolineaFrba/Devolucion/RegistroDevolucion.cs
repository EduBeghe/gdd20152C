using AerolineaFrba.Utils;
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

namespace AerolineaFrba.Devolucion
{
    public partial class RegistroDevolucion : Form
    {
        int retorno;

        public RegistroDevolucion()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloNumeros(this.pnr, "PNR") &&
                Validacion.soloNumeros(this.codigo, "Codigo")
                // && Validacion.fechaMayorMenos 
                ) {
                    if ( devolucionDe.SelectedItem == "Cancelar Pasaje") retorno = new DevolucionRepository().devolverCompra( int.Parse(pnr.Text), int.Parse(codigo.Text), motivo.Text, 1 );
                    else retorno = new DevolucionRepository().devolverCompra(int.Parse(pnr.Text), int.Parse(codigo.Text), motivo.Text, 0);

                if (retorno == 0)
                {
                    MessageBox.Show("Devolución realizada con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la devolución");
                }
            }
            
                

        }

        private void RegistroDevolucion_Load(object sender, EventArgs e)
        {
            devolucionDe.Items.Add("Cancelar Pasaje");
            devolucionDe.Items.Add("Cancelar Encomienda");
            
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void motivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void devolucionDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( this.pnr.Text != ""  )
            {
                if (this.devolucionDe.SelectedItem == "Cancelar Pasaje")
                {
                    this.codigo.DataSource = new BindingSource(new BindingList<int>(new PasajesRepository().getCodigosCancelar(
                    Convert.ToInt32(pnr.Text), 1)), null);
                }
                else this.codigo.DataSource = new BindingSource(new BindingList<int>(new PasajesRepository().getCodigosCancelar(
                    Convert.ToInt32(pnr.Text), 0)), null);
            }
        }


        private void pnr_TextChanged(object sender, EventArgs e)
        {
            if (this.pnr.Text != "")
            {
                if (this.devolucionDe.SelectedItem == "Cancelar Pasaje")
                {
                    this.codigo.DataSource = new BindingSource(new BindingList<int>(new PasajesRepository().getCodigosCancelar(
                    Convert.ToInt32(pnr.Text), 1)), null);
                }
                else this.codigo.DataSource = new BindingSource(new BindingList<int>(new PasajesRepository().getCodigosCancelar(
                    Convert.ToInt32(pnr.Text), 0)), null);
            }
        }
    }
}
