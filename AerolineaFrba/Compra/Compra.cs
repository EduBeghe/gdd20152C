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
        List<Pasaje> pasajes;
        Boolean vueloSeleccionado = false;

        public Compra()
        {
            InitializeComponent();
        }

        internal void ShowDialog( Boolean administrador )
        {
            this.esAdministrador = administrador;
            this.disponibilidad.DataSource = null;
            this.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ciudad ciudadOrigen = ( Ciudad ) origen.SelectedItem;
            Ciudad ciudadDestino = (Ciudad) destino.SelectedItem;
            if (!vueloSeleccionado) this.disponibilidad.DataSource = DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles", Convert.ToDateTime(fecha.Value), ciudadOrigen.Nombre_Ciudad, ciudadDestino.Nombre_Ciudad);
            else MessageBox.Show("Una vez seleccionado el vuelo no lo puede cambiar para esta comprar");
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            this.origen.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
            this.destino.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // if (disponibilidad.SelectedRows.Count != 0)  new ListadoButacas().ShowDialog( disponibilidad.SelectedRows[0].Cells[0].Value );
           // else MessageBox.Show("Debe seleccionar un vuelo para seleccionar butacas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pasajes.Count == 0) MessageBox.Show("Debe comprar un pasaje para pagar");
            new datosTarjeta().ShowDialog( pasajes, esAdministrador );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (disponibilidad.SelectedRows.Count != 0) encomienda = new Encomienda().ShowDialog();
            else MessageBox.Show("Debe seleccionar un vuelo para cargar su encomienda");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (disponibilidad.SelectedRows.Count != 0)
            {
                vueloSeleccionado = true;
                pasajes.Add(new ListadoButacas().ShowDialog(disponibilidad.SelectedRows[0].Cells[0].Value, disponibilidad.SelectedRows[0].Cells[3].Value));
            }
            else MessageBox.Show("Debe seleccionar un vuelo para seleccionar butacas");
        }
    }
}
