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
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Login;

namespace AerolineaFrba
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void AltaAeronaveButton_Click(object sender, EventArgs e)
        {
            new AltaAeronave().ShowDialog();
        }

        private void BuscarAeronaveButton_Click(object sender, EventArgs e)
        {
            new ListadoAeronave().ShowDialog();
        }

        private void AltaRutaButton_Click(object sender, EventArgs e)
        {
            new AltaRuta().ShowDialog();
        }

        private void BuscarRutaButton_Click(object sender, EventArgs e)
        {
            new ListadoRuta().ShowDialog();
        }

        private void AltaRolButton_Click(object sender, EventArgs e)
        {
            new AltaRol().ShowDialog();
        }

        private void BuscarRolButton_Click(object sender, EventArgs e)
        {
            new ListadoRol().ShowDialog();
        }

        private void AltaCiudadButton_Click(object sender, EventArgs e)
        {
            new AltaCiudad().ShowDialog();
        }

        private void BuscarCiudadButton_Click(object sender, EventArgs e)
        {
            new ListadoCiudad().ShowDialog();
        }

        private void CanjeMillasButton_Click(object sender, EventArgs e)
        {
            new canjeMillas().ShowDialog();
        }

        private void ConsultarMillasButton_Click(object sender, EventArgs e)
        {
            new ConsultaMillas().ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new LoginScreen().ShowDialog();
        }

       
    }
}
