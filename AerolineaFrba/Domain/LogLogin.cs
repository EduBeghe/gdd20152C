using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class LogLogin
    {
        public int logId { get; set; }
        public string nombreUsuario { get; set; }
        public DateTime fechaYHora { get; set; }
        public int intentosFallidos { get; set; }

        public LogLogin( int logId, string nombreUsuario, DateTime fechaYHora, int intentosFallidos )
        {
            this.logId = logId;
            this.nombreUsuario = nombreUsuario;
            this.fechaYHora = fechaYHora;
            this.intentosFallidos = intentosFallidos;
        }
    }
}
