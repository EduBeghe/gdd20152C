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
using AerolineaFrba.Utils;
using AerolineaFrba.Abm_Ciudad;

namespace AerolineaFrba.Compra
{
    public partial class Compra : Form
    {
        int butaca = -1;
        int encomienda = -1;
        Boolean esAdministrador;

        public Compra()
        {
            InitializeComponent();
        }

        internal void ShowDialog( Boolean administrador )
        {
            this.esAdministrador = administrador;
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ciudad ciudadOrigen = ( Ciudad ) origen.SelectedItem;
            Ciudad ciudadDestino = (Ciudad) destino.SelectedItem;
            this.disponibilidad.DataSource = DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles", Convert.ToDateTime( fecha.Value ), ciudadOrigen.Nombre_Ciudad, ciudadDestino.Nombre_Ciudad );
            
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (disponibilidad.SelectedRows.Count != 0) butaca = new ListadoButacas().ShowDialog( disponibilidad.SelectedRows[0].Cells[0].Value );
            else MessageBox.Show("Debe seleccionar un vuelo para seleccionar butacas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (disponibilidad.SelectedRows.Count != 0 ){
                if (butaca == -1 ) MessageBox.Show("Debe seleccionar una butaca para comprar el pasaje");
                else 
                {
                    new CargarDatos().ShowDialog( disponibilidad.SelectedRows[0].Cells[0].Value, butaca, encomienda, esAdministrador );
                } 
            } else MessageBox.Show("Debe seleccionar una vuelo para comprar el pasaje");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (disponibilidad.SelectedRows.Count != 0) encomienda = new Encomienda().ShowDialog();
            else MessageBox.Show("Debe seleccionar un vuelo para cargar su encomienda");
        }
    }
}
