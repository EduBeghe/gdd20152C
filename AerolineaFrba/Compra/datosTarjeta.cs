﻿using AerolineaFrba.Utils;
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

namespace AerolineaFrba.Compra
{
    public partial class datosTarjeta : Form
    {
        List<Pasaje> pasajes;
        List<Domain.Encomienda> encomiendas;
        Boolean esAdministrador;

        public datosTarjeta()
        {
            InitializeComponent();
        }

        internal int ShowDialog( List<Pasaje> pasajes, List<Domain.Encomienda> encomiendas ,Boolean esAdministrador )
        {
            this.pasajes = pasajes;
            this.encomiendas = encomiendas;
            this.esAdministrador = esAdministrador;
            this.ShowDialog();
            return 0;
        }

        private void datosTarjeta_Load(object sender, EventArgs e)
        {
            this.tipoTarjeta.Items.Add("Credito");
            this.tipoTarjeta.Items.Add("Debito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) && Validacion.soloNumeros(this.numeroTarjeta, "Numero de Tarjeta")
                && Validacion.soloNumeros(this.codSeg, "Codigo de Seguridad") )
            {
                foreach (Pasaje pasaje in pasajes)
                {
                    new PasajesRepository().comprarPasajes( 
                        pasaje.Butaca_Asociada, 
                        pasaje.viaje.Cod_Viaje, 
                        pasaje.cliente.Cliente_Apellido, 
                        pasaje.cliente.Nro_Dni,
                        "Tarjeta",
                        Convert.ToInt64( numeroTarjeta.Text ),
                        Convert.ToInt32( codSeg.Text ),
                        Convert.ToDateTime( vencimiento.Value ),
                        tipoTarjeta.SelectedItem.ToString()
                        );
                }
                foreach (Domain.Encomienda encomienda in encomiendas)
                {
                   int retorno = new EncomiendasRepository().comprarPaquete(
                        encomienda.Kgs_A_Enviar,
                        encomienda.codViaje,
                        encomienda.cliente.Cliente_Apellido,
                        encomienda.cliente.Nro_Dni,
                        "Tarjeta",
                        Convert.ToInt64(numeroTarjeta.Text),
                        Convert.ToInt32(codSeg.Text),
                        Convert.ToDateTime(vencimiento.Value),
                        tipoTarjeta.SelectedItem.ToString()
                        );
                   if (retorno == -1) MessageBox.Show("No hay disponibilidad para la cantidad de kilogramos ingresada");

                }
                this.Close();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!esAdministrador) MessageBox.Show("Debe ser administrador para poder pagar en efectivo");
            else 
            {
                    foreach (Pasaje pasaje in pasajes)
                    {
                        new PasajesRepository().comprarPasajes(
                            pasaje.Butaca_Asociada,
                            pasaje.viaje.Cod_Viaje,
                            pasaje.cliente.Cliente_Apellido,
                            pasaje.cliente.Nro_Dni,
                            "Efectivo",
                            1,
                            1,
                            Convert.ToDateTime(vencimiento.Value),
                            "a"
                            );
                    }
                    foreach (Domain.Encomienda encomienda in encomiendas)
                    {
                        int retorno = new EncomiendasRepository().comprarPaquete(
                            encomienda.Kgs_A_Enviar,
                            encomienda.codViaje,
                            encomienda.cliente.Cliente_Apellido,
                            encomienda.cliente.Nro_Dni,
                            "Efectivo",
                            1,
                            1,
                            Convert.ToDateTime(vencimiento.Value),
                            "a"
                            );
                        if (retorno == -1) MessageBox.Show("No hay disponibilidad para la cantidad de kilogramos ingresada");
                    }
                }
            this.Close();
        }
      
    }
}
