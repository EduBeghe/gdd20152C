﻿using System;
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
            //this.ciudadesGrid.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().findCiudad()), null); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ciudad = (Ciudad)ciudadesGrid.SelectedRows[0].DataBoundItem;
            new CiudadRepository().darDeBaja(ciudad);
            MessageBox.Show("Rol eliminada con exito");
            //this.ciudadesGrid.DataSource = new BindingSource(new BindingList<Ciudad>(new CiudadRepository().findCiudad()), null); 
        }
    }
}
