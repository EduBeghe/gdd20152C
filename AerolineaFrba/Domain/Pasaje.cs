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
        public Cliente cliente { get; set; }
        public Viaje viaje { get; set; }
        public int pnr { get; set; }

        public Pasaje( int idPasaje, Cliente cliente, Viaje viaje, int pnr )
        {
            this.idPasaje = idPasaje;
            this.cliente = cliente;
            this.viaje = viaje;
            this.pnr = pnr;
        }
    }
}
