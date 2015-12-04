using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class AltaViaje : Form
    {
        public AltaViaje()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AltaViaje_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet3.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet3.Aeronaves);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.RutasAereas' Puede moverla o quitarla según sea necesario.
            this.rutasAereasTableAdapter.Fill(this.gD2C2015DataSet.RutasAereas);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
