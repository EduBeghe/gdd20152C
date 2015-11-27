using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Pasaje
    {
        public int Cod_Pasaje { get; set; }
        public DateTime Fecha_Viaje { get; set; }
        public Viaje viaje { get; set; }
        public int Butaca_Asociada { get; set; }
        public Cliente cliente { get; set; }
        public int Pasaje_Precio { get; set; }

        public Pasaje( int Cod_Pasaje, DateTime Fecha_Viaje, Viaje viaje, int Butaca_Asociada, Cliente cliente, int Pasaje_Precio )
        {
            this.Cod_Pasaje = Cod_Pasaje;
            this.Fecha_Viaje = Fecha_Viaje;
            this.viaje = viaje;
            this.Butaca_Asociada = Butaca_Asociada;
            this.cliente = cliente;
            this.Pasaje_Precio = Pasaje_Precio;
        }
    }
}
