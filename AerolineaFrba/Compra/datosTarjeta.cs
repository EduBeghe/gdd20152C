using AerolineaFrba.Utils;
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
        Boolean esAdministrador;

        public datosTarjeta()
        {
            InitializeComponent();
        }

        internal void ShowDialog( List<Pasaje> pasajes, Boolean esAdministrador )
        {
            this.pasajes = pasajes;
            this.esAdministrador = esAdministrador;
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
                foreach (Pasaje pasaje in pasajes)
                {
                    new PasajesRepository().comprarPasajes( 
                        pasaje.Butaca_Asociada, 
                        pasaje.viaje.Cod_Viaje, 
                        pasaje.cliente.Cliente_Apellido, 
                        pasaje.cliente.Nro_Dni, 
                        // forma de pago ,
                        Convert.ToInt32( numeroTarjeta.Text ),
                        Convert.ToInt32( codSeg.Text ),
                        Convert.ToDateTime( vencimiento.Value )
                        // , tipo de tarjeta
                        );
                }
                
            }

        }

      
    }
}
