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
    public partial class Motivo : Form
    {
        RutaAerea ruta;

        public Motivo()
        {
            InitializeComponent();
        }
        
        internal void ShowDialog( RutaAerea ruta )
        {
            this.ruta = RutaAerea.Copy(ruta);
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RutaAereaRepository().darDeBaja(ruta, motivoTextBox.Text );
            MessageBox.Show("Ruta dada de baja con exito");
            this.Close();
        }
    }
}