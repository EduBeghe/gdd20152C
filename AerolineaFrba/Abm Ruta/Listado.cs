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
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AltaAeronave : Form
    {
        public AltaAeronave()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rutasGrid.DataSource = new BindingSource(new BindingList<RutaAerea>(new RutaAereaRepository().findRuta()), null); 
        }
    }
}
