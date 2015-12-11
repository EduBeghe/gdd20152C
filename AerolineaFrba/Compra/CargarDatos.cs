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
        int codViaje;
        int butaca;
        int kgs;
        Pasaje pasaje;
        Domain.Encomienda encomienda;
        DateTime fechaSalida;
        Cliente cl = null ;

        public CargarDatos()
        {
            InitializeComponent();
        }
        
        internal Object ShowDialog(int codViaje, DateTime fechaSalida , int butaca, int kgs )
        {
            this.codViaje = codViaje;
            this.fechaSalida = fechaSalida;
            this.butaca = butaca;
            this.kgs = kgs;
            this.ShowDialog();
            if (butaca != -1) return pasaje;
            else return encomienda;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
            if ( dni.Text.Length == 7 && Apellido.Text != "")
            {
                if ( DBAdapter.executeProcedureWithReturnValue( "Verificar_Cliente", Convert.ToInt32(dni.Text), Apellido.Text ) == -1 )
                {
                    cl = new ClientesRepository().getCliente(Convert.ToInt32(dni.Text), Apellido.Text );
                    Nombre.Text = cl.Cliente_Nombre;
                    Direccion.Text = cl.Cliente_Direccion;
                    Telefono.Text = cl.Cliente_Telefono.ToString();
                    Mail.Text = cl.Cliente_Mail;
                    fecha.Value = cl.Cliente_Fecha_Nacimiento;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls) &&
                Validacion.soloLetras(this.Apellido, Apellido.Name) &&
                Validacion.soloNumeros(this.dni, dni.Name) &&
                Validacion.soloLetras(this.Nombre, Nombre.Name) &&
                Validacion.soloNumeros(this.Telefono, Telefono.Name) &&
                Validacion.emailValido( this.Mail )
                // && Validacion.fechaMenorAlDiaDeHoy( fecha, "Fecha de Nacimiento" )
                // validar butaca y encomienda ?
                ) 
                { 
                    if ( cl == null ) cl = new Cliente( 
                        Convert.ToInt32( dni.Text ),
                        Nombre.Text, 
                        Apellido.Text,
                        Direccion.Text,
                        Convert.ToInt32( Telefono.Text ),
                        Mail.Text,
                        Convert.ToDateTime( fecha.Value ),
                        0 );
                    if (butaca != -1)
                    {
                        pasaje = new Pasaje(
                            codViaje,
                            fechaSalida,
                            new ViajesRepository().getViaje(codViaje),
                            butaca,
                            cl,
                            0 // Precio 
                        );
                    }
                    if (kgs != -1)
                    {
                        encomienda = new Domain.Encomienda(kgs, codViaje, cl);
                    }
                    this.Close();
                }
        }

        private void tarjetaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {
        }

        private void Apellido_TextChanged(object sender, EventArgs e)
        {
            if (dni.Text.Length == 7 && Apellido.Text != "")
            {
                if (DBAdapter.executeProcedureWithReturnValue("Verificar_Cliente", Convert.ToInt32(dni.Text), Apellido.Text) == -1)
                {
                    cl = new ClientesRepository().getCliente(Convert.ToInt32(dni.Text), Apellido.Text);
                    Nombre.Text = cl.Cliente_Nombre;
                    Direccion.Text = cl.Cliente_Direccion;
                    Telefono.Text = cl.Cliente_Telefono.ToString();
                    Mail.Text = cl.Cliente_Mail;
                    fecha.Value = cl.Cliente_Fecha_Nacimiento;
                }
            }
        }
    }
}
