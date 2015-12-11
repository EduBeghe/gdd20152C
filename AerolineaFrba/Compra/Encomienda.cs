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

namespace AerolineaFrba.Compra
{
    public partial class Encomienda : Form
    {
        int codViaje;
        int kgs = -1;
        Domain.Encomienda encomienda;

        public Encomienda()
        {
            InitializeComponent();
        }

        internal Domain.Encomienda ShowDialog(object func)
        {
            this.codViaje = Convert.ToInt32(func);
            this.ShowDialog();
            return encomienda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) && Validacion.soloNumeros( this.kgsTextBox, "Kgs a enviar"))
            { 
                kgs = Convert.ToInt32(kgsTextBox.Text);
                encomienda = ( Domain.Encomienda ) new CargarDatos().ShowDialog(codViaje, new DateTime(), -1, kgs);
                this.Close();
            }
            else MessageBox.Show("Debe cargar los kgs a enviar para confirmar");
        }
    }
}
