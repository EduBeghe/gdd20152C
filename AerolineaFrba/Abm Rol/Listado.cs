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
using AerolineaFrba.Domain;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if ( nombre.Text != "" ) this.rolGrid.DataSource = new BindingSource(new BindingList<Rol>(new RolesRepository().findRol( nombre.Text )), null);
            else this.rolGrid.DataSource = new BindingSource(new BindingList<Rol>(new RolesRepository().getRoles()), null); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rol = (Rol) rolGrid.SelectedRows[0].DataBoundItem;
            new RolesRepository().darDeBaja(rol);
            MessageBox.Show("Rol eliminada con exito");
            //this.rolGrid.DataSource = new BindingSource(new BindingList<Rol>(new RolesRepository().findRol()), null); 
            // CLEAN GRID ?
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
