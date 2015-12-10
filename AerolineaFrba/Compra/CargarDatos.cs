using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using AerolineaFrba.Domain;

namespace AerolineaFrba.Compra
{
    public partial class CargarDatos : Form
    {
        Boolean esAdministrador;
        int codAeronave;
        int butaca;
        int encomienda;

        public CargarDatos()
        {
            InitializeComponent();
        }
        
        internal void ShowDialog(object codAeronave, int butaca, int encomienda, Boolean administrador )
        {
            this.codAeronave = Convert.ToInt32(codAeronave);
            this.butaca = butaca;
            this.encomienda = encomienda;
            this.esAdministrador = administrador;
            this.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
            Cliente cl = new ClientesRepository().getCliente(Convert.ToInt32(dni.Text), Apellido.Text );
            Nombre.Text = cl.Cliente_Nombre;
            Direccion.Text = cl.Cliente_Direccion;
            Telefono.Text = cl.Cliente_Telefono.ToString();
            Mail.Text = cl.Cliente_Mail;
            fecha.Value = cl.Cliente_Fecha_Nacimiento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloLetras(this.Apellido, Apellido.Name) &&
                Validacion.soloNumeros(this.dni, dni.Name) &&
                Validacion.soloLetras(this.Nombre, Nombre.Name) &&
                Validacion.soloNumeros(this.Telefono, Telefono.Name) &&
                Validacion.emailValido( this.Mail ) &&
                Validacion.fechaMenorAlDiaDeHoy( fecha, "Fecha de Nacimiento" )
                // validar butaca y encomienda ?
                ) {  }
        }

        private void tarjetaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new datosTarjeta().ShowDialog( 
                Apellido.Text, 
                Convert.ToInt32( dni.Text ), 
                Nombre.Text, 
                Direccion.Text, 
                Convert.ToInt32( Telefono.Text ), 
                Mail.Text, 
                Convert.ToDateTime( fecha ), 
                butaca, 
                codAeronave );
        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {
            if (esAdministrador) this.efectivo.Visible = true;

        }
    }
}
