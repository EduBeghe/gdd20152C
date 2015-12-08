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
using AerolineaFrba.Utils;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AltaCiudad : Form
    {
        public AltaCiudad()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            { 
                var retorno = new CiudadRepository().darDeAlta(nombreCiudad.Text);
                if (retorno == 0)
                {
                    MessageBox.Show("Ciudad creada exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La ciudad que quiere crear ya existe");
                }
            }
        }

        private void AltaCiudad_Load(object sender, EventArgs e)
        {

        }

        private void AltaCiudad_Load_1(object sender, EventArgs e)
        {

        }
    }
}
