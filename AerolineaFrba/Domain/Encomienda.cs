using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Encomienda
    {
        public int Cod_Encomiendas { get; set; }
        public int Precio_Encomienda { get; set; }
        public int Kgs_A_Enviar { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public Viaje viaje { get; set; }
        public Cliente cliente { get; set; }
        public int codViaje { get; set; }

        public Encomienda(int Cod_Encomiendas, int Precio_Encomienda, int Kgs_A_Enviar, DateTime Fecha_Compra, Viaje viaje, Cliente cliente )
        {
            this.Cod_Encomiendas = Cod_Encomiendas;
            this.Precio_Encomienda = Precio_Encomienda;
            this.Kgs_A_Enviar = Kgs_A_Enviar;
            this.Fecha_Compra = Fecha_Compra;
            this.viaje = viaje;
            this.cliente = cliente;
        }

        public Encomienda(int Kgs_A_Enviar, int codViaje, Cliente cliente )
        {
            this.Kgs_A_Enviar = Kgs_A_Enviar;
            this.codViaje = codViaje;
            this.cliente = cliente;
        }
    }
}
