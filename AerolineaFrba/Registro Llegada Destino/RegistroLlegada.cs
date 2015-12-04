using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegada : Form
    {
        public RegistroLlegada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet4.Ciudades);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet2.Aeronaves' Puede moverla o quitarla según sea necesario.
            this.aeronavesTableAdapter.Fill(this.gD2C2015DataSet2.Aeronaves);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
