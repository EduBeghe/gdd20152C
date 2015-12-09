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
    public partial class ConsultaMillas : Form
    {
        public ConsultaMillas()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var clientesRepository = new ClientesRepository();
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloNumeros(this.dni, dni.Name) && Validacion.soloLetras( this.apellido, apellido.Name ))
            {

                int millas = clientesRepository.getMillas(clientesRepository.getCliente(Convert.ToInt32(dni.Text), apellido.Text));
                MessageBox.Show("Sus millas son : " + millas);
                this.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
