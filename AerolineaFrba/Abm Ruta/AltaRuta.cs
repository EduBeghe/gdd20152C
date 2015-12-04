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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AltaRuta : Form
    {
        public AltaRuta()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new RutaAereaRepository().darDeAlta(
                new RutaAerea( 
                    Convert.ToInt32( codigo ),
                    ( Ciudad ) origen.SelectedItem,
                    ( Ciudad ) destino.SelectedItem,
                    ( TipoServicio ) servicio.SelectedItem,
                    Convert.ToInt32( costoKg ),
                    Convert.ToInt32( costoPasaje ),
                    ( bool ) true // MIRAR! Agregar estado a la form 
                    ));
        }

        private void AltaRuta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet5.Tipos_De_Servicios' Puede moverla o quitarla según sea necesario.
            this.tipos_De_ServiciosTableAdapter.Fill(this.gD2C2015DataSet5.Tipos_De_Servicios);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet4.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet4.Ciudades);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet2.Tipos_De_Servicios' Puede moverla o quitarla según sea necesario.
            this.tipos_De_ServiciosTableAdapter.Fill(this.gD2C2015DataSet2.Tipos_De_Servicios);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet1.Ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet1.Ciudades);

        }
    }
}
