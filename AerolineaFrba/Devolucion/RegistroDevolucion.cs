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
                    var retorno = new DevolucionRepository().devolverCompra(DateTime.Today, int.Parse(pnr.Text), int.Parse(codigo.Text), motivo.Text);

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

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void motivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
