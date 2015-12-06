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
using AerolineaFrba.Domain;
using AerolineaFrba.Abm_Ciudad;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ListadoAeronave : Form
    {
        public ListadoAeronave()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            if (codigo.Text != "")
            {
                this.aeronavesGrid.DataSource = new BindingSource(new BindingList<Aeronave>(new AeronaveRepository().findAeronave(
                matricula.Text, Convert.ToInt32(codigo.Text), (Fabricante)fabricante.SelectedItem, (TipoServicio)servicio.SelectedItem)), null);
            }
            else
            {
                this.aeronavesGrid.DataSource = new BindingSource(new BindingList<Aeronave>(new AeronaveRepository().findAeronave(
                matricula.Text, null, (Fabricante)fabricante.SelectedItem, (TipoServicio)servicio.SelectedItem)), null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aeronave = (Aeronave)aeronavesGrid.SelectedRows[0].DataBoundItem;
            new AeronaveRepository().darDeBajaXVidaUtil(aeronave);
            MessageBox.Show("Aeronave dada de baja con exito");
            //this.aeronavesGrid.DataSource = new BindingSource(new BindingList<Aeronave>(new  AeronaveRepository().findAeronave(
            //    matricula.Text, 
            //    Convert.ToInt32( codigo.Text ), 
            //    (Fabricante) fabricante.SelectedItem, 
            //    (TipoServicio) servicio.SelectedItem
            //    )), null); 
            // GRID CLEAN ?
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // necesario el import de las otras forms?
            new BajaPorProblemasTecnicos().ShowDialog((Aeronave)aeronavesGrid.SelectedRows[0].DataBoundItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ModificarAeronave().ShowDialog((Aeronave)aeronavesGrid.SelectedRows[0].DataBoundItem);
        }

        private void ListadoAeronave_Load(object sender, EventArgs e)
        {
            servicio.DisplayMember = "Descripcion_Servicio";
            //servicio.ValueMember = "Cod_Tipo_Servicio";
            fabricante.DisplayMember = "Nombre_Fabricante";
            //fabricante.ValueMember = "Cod_Fabricante";
            this.servicio.DataSource = new BindingSource(new BindingList<TipoServicio>(new TipoServicioRepository().getServicios()), null);
            this.fabricante.DataSource = new BindingSource(new BindingList<Fabricante>(new FabricantesRepository().getFabricantes()), null);
        }
    }
}
