using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class EstadoAeronave
    {
        public int Cod_Estado { get; set; }
        public Aeronave aeronave { get; set; }
        public bool Fuera_De_Servicio { get; set; }
        public bool Vida_Util { get; set; }
        public DateTime Fecha_Fuera_Servicio { get; set; }
        public DateTime Fecha_Reinicio_Servicio { get; set; }
        public DateTime Fecha_Baja_Definitiva { get; set; }


        public EstadoAeronave(int Cod_Estado, Aeronave aeronave, bool Fuera_De_Servicio, bool Vida_Util ,DateTime Fecha_Fuera_Servicio, DateTime Fecha_Reinicio_Servicio, DateTime Fecha_Baja_Definitiva )
        {
            this.Cod_Estado = Cod_Estado;
            this.aeronave = aeronave;
            this.Fuera_De_Servicio = Fuera_De_Servicio;
            this.Vida_Util = Vida_Util;
            this.Fecha_Fuera_Servicio = Fecha_Fuera_Servicio;
            this.Fecha_Reinicio_Servicio = Fecha_Reinicio_Servicio;
            this.Fecha_Baja_Definitiva = Fecha_Baja_Definitiva;

        }
    }
}
