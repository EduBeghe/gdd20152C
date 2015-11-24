using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class LogCancelaciones
    {
        public DateTime fechaDevolucion { get; set; }
        public Pasaje pasaje { get; set; }
        public string motivoCancelacion { get; set; }


        public LogCancelaciones( DateTime fechaDevolucion, Pasaje pasaje, string motivoCancelacion )
        {
            this.fechaDevolucion = fechaDevolucion;
            this.pasaje = pasaje;
            this.motivoCancelacion = motivoCancelacion;
        }
    }
}
