using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Viaje
    {
        public int idViaje { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }
        public Aeronave aeronave { get; set; }
        public RutasAereas rutaAerea { get; set; }


        public Viaje( int idViaje, DateTime fechaSalida, DateTime fechaLlegada, DateTime fechaLlegadaEstimada, Aeronave aeronave, RutasAereas rutaAerea )
        {
            this.idViaje = idViaje;
            this.fechaSalida = fechaSalida;
            this.fechaLlegada = fechaLlegada;
            this.fechaLlegadaEstimada = fechaLlegadaEstimada;
            this.aeronave = aeronave;
            this.rutaAerea = rutaAerea;
        }
    }
}
