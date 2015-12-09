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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoCiudad : Form
    {
        public ListadoCiudad()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "") this.ciudadesGrid.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().findCiudad(nombre.Text)), null);
            else this.ciudadesGrid.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().getCiudades()), null); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ciudadesGrid.SelectedRows.Count != 0)
            {
                var ciudad = (Ciudad)ciudadesGrid.SelectedRows[0].DataBoundItem;
                if (Convert.ToBoolean(ciudadesGrid.SelectedRows[0].Cells[2].Value) == true)
                {
                    new CiudadRepository().darDeBaja(ciudad);
                    MessageBox.Show("Ciudad eliminada con exito");
                    this.Close();
                }
                else { MessageBox.Show("No puede dar de baja una ciudad deshabilitada"); }
                
            }
            else MessageBox.Show("Debe seleccionar una ciudad para dar de baja");
        }

        private void ListadoCiudad_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (ciudadesGrid.SelectedRows.Count != 0)
            {
               new ModificarCiudad().ShowDialog((Ciudad)ciudadesGrid.SelectedRows[0].DataBoundItem);
            }
            else MessageBox.Show("Debe seleccionar una ciudad para modificar");
        }
    }
}
