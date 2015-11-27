using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Pasaje
    {
        public int idPasaje { get; set; }
        // Fecha de viaje ( agregarla tmb en el parse )
        public Cliente cliente { get; set; }
        public Viaje viaje { get; set; }
        public int pnr { get; set; } // No esta en la tabla 
        // Butaca es un int en la tabla, sigue siendo una clase ? 
        public Butaca butaca { get; set; }
        // Precio ( agregarlo al parse )

        public Pasaje( int idPasaje, Cliente cliente, Viaje viaje, int pnr, Butaca butaca )
        {
            this.idPasaje = idPasaje;
            this.cliente = cliente;
            this.viaje = viaje;
            this.pnr = pnr;
            this.butaca = butaca;
        }
    }
}
