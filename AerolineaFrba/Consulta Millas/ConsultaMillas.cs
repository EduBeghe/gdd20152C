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
            //var millas = clientesRepository.getMillas( clientesRepository.getCliente( dni, apellido ));
            //MessageBox.Show("Sus millas son :" + millas );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
