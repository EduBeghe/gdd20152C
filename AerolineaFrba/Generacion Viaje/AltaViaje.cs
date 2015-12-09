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
            int resultado =  new ViajesRepository().generarViaje( 
                ( RutaAerea ) ruta.SelectedItem,
                ( Aeronave ) aeronave.SelectedItem,
                Convert.ToDateTime( salida.Value ),
                Convert.ToDateTime( llegadaEstimada.Value ));
            if (resultado == -1) MessageBox.Show("Fechas Ingresadas invalidas");
            else if (resultado == -2) MessageBox.Show("El servicio de la Aeronave y la ruta no concuerdan");
            else {
                MessageBox.Show("Viaje dado de alta exitosamente");
                this.Close();
            }
        }

        private void AltaViaje_Load(object sender, EventArgs e)
        {
            
            BindingSource aeronaveSource = new BindingSource(new BindingList<Aeronave>(new AeronaveRepository().getAeronaves()), null);
            this.aeronave.DataSource = aeronaveSource;
            this.aeronave.DisplayMember = "Matricula";
            BindingSource rutaAereaSource = new BindingSource(new BindingList<RutaAerea>(new RutaAereaRepository().getRutas()), null);
            this.ruta.DataSource = rutaAereaSource;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
