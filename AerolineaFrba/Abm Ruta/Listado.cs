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

namespace AerolineaFrba.Abm_Aeronave
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
            // llamar a form modificar
        }
    }
}
