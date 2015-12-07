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
    public partial class ModificarCiudad : Form
    {
        Ciudad ciudad;

        public ModificarCiudad()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Ciudad ciudad)
        {
            this.ciudad = Ciudad.Copy(ciudad);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CiudadRepository().modificarNombre(ciudad, nombre.Text);
            MessageBox.Show("Nombre de Ciudad modificada con exito");
            this.Close();
        }
    }
}
