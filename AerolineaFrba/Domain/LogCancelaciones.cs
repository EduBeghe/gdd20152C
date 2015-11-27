using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class LogCancelaciones
    {
        public int Codigo_Devolucion { get; set; }
        public DateTime Fecha_Devolucion { get; set; }
        //public Pasaje pasaje { get; set; }
        public string Motivo { get; set; }


        public LogCancelaciones( int Codigo_Devolucion, DateTime Fecha_Devolucion, Pasaje pasaje ) 
        {
            this.Codigo_Devolucion = Codigo_Devolucion;
            this.Fecha_Devolucion = Fecha_Devolucion;
            // this.pasaje = pasaje;
            this.Motivo = Motivo;
        }
    }
}
