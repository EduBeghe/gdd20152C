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
using AerolineaFrba.Login;
using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Listado_Estadistico;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Registro_Llegada_Destino;

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
            new AltaAeronave().ShowDialog(this);
        }

        private void BuscarAeronaveButton_Click(object sender, EventArgs e)
        {
            new ListadoAeronave().ShowDialog(this);
        }

        private void AltaRutaButton_Click(object sender, EventArgs e)
        {
            new AltaRuta().ShowDialog(this);
        }

        private void BuscarRutaButton_Click(object sender, EventArgs e)
        {
            new ListadoRuta().ShowDialog(this);
        }

        private void AltaRolButton_Click(object sender, EventArgs e)
        {
            new AltaRol().ShowDialog(this);
        }

        private void BuscarRolButton_Click(object sender, EventArgs e)
        {
            new ListadoRol().ShowDialog(this);
        }

        private void AltaCiudadButton_Click(object sender, EventArgs e)
        {
            new AltaCiudad().ShowDialog(this);
        }

        private void BuscarCiudadButton_Click(object sender, EventArgs e)
        {
            new ListadoCiudad().ShowDialog(this);
        }

        private void CanjeMillasButton_Click(object sender, EventArgs e)
        {
            new canjeMillas().ShowDialog(this);
        }

        private void ConsultarMillasButton_Click(object sender, EventArgs e)
        {
            new ConsultaMillas().ShowDialog(this);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            new LoginScreen().ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListadoEstadistico().ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AltaViaje().ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RegistroLlegada().ShowDialog(this);
        }

       
    }
}
