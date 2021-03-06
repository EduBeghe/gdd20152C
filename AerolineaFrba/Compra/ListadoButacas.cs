﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using AerolineaFrba.Compra;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoButacas : Form
    {
        int codViaje;
        int butaca;
        DateTime fechaSalida;
        Pasaje pasaje;  
  
        public ListadoButacas()
        {
            InitializeComponent();
        }

        internal Pasaje ShowDialog(object func,object func2 )
        {
            this.codViaje = Convert.ToInt32(func);
            this.fechaSalida = Convert.ToDateTime(func2);
            this.ShowDialog();
            return pasaje;
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoButacas_Load(object sender, EventArgs e)
        {
            this.butacas.DataSource = DBAdapter.retrieveDataTable("Butacas_Libres", codViaje );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (butacas.SelectedRows.Count != 0)
            {
                butaca = Convert.ToInt32( butacas.SelectedRows[0].Cells[0].Value ) ;
                pasaje = ( Pasaje ) new CargarDatos().ShowDialog(codViaje, fechaSalida , butaca, -1);
                this.Close();
            }
            
        }

    }
}
