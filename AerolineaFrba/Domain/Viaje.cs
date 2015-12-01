using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Repositories;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Domain
{
        
    public class Viaje
    {
        public int Cod_Viaje { get; set; }
        public RutaAerea rutaAerea { get; set; }
        public Aeronave aeronave { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Llegada { get; set; }
        public DateTime Fecha_Llegada_Estimada { get; set; }



        public Viaje(int Cod_Viaje, RutaAerea rutaAerea, Aeronave aeronave, DateTime Fecha_Salida, DateTime Fecha_Llegada, DateTime Fecha_Llegada_Estimada)
        {
            this.Cod_Viaje = Cod_Viaje;
            this.rutaAerea = rutaAerea;
            this.aeronave = aeronave;
            this.Fecha_Salida = Fecha_Salida;
            this.Fecha_Llegada = Fecha_Llegada;
            this.Fecha_Llegada_Estimada = Fecha_Llegada_Estimada;
        }
    }
}
