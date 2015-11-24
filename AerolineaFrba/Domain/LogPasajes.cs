using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class LogPasajes
    {
        public int idLog { get; set; }
        public Pasaje pasaje { get; set; }
        public DateTime fechaCompra { get; set; }

        public LogPasajes( int idLog, Pasaje pasaje, DateTime fechaCompra )
        {
            this.idLog = idLog;
            this.pasaje = pasaje;
            this.fechaCompra = fechaCompra;
        }
    }
}
