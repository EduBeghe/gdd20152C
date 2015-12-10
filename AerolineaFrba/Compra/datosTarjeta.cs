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

namespace AerolineaFrba.Compra
{
    public partial class datosTarjeta : Form
    {
        string apellido;
        string nombre;
        int dni;
        string domicilio;
        int telefono;
        string mail;
        DateTime nacimiento;
        int butaca;
        int aeronave;

        public datosTarjeta()
        {
            InitializeComponent();
        }

        internal void ShowDialog( string apellido, int dni, string nombre, string domicilio, int telefono, string email, DateTime nacimiento, int butaca, int aeronave )
        {
            this.apellido = apellido;
            this.dni = dni;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mail = email;
            this.nacimiento = nacimiento;
            this.butaca = butaca;
            this.aeronave = aeronave;
            this.ShowDialog();
        }

        private void datosTarjeta_Load(object sender, EventArgs e)
        {
            this.tipoTarjeta.Items.Add("Credito");
            this.tipoTarjeta.Items.Add("Debito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) && Validacion.soloNumeros(this.numeroTarjeta, "Numero de Tarjeta")
                && Validacion.soloNumeros(this.codSeg, "Codigo de Seguridad") && Validacion.fechaMayorAlDiaDeHoy(vencimiento, "Vencimiento"))
            {
              // new PasajesRepository().comprarPasajes( butaca, aeronave); 
            }

        }

      
    }
}