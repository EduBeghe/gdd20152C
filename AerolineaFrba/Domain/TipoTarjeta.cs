using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class TipoTarjeta
    {
        public int idTipoTarjeta { get; set; }
        public string nombreTarjeta { get; set; }

        public TipoTarjeta( int idTipoTarjeta, string nombreTarjeta )
        {
            this.idTipoTarjeta = idTipoTarjeta;
            this.nombreTarjeta = nombreTarjeta;
        }
    }
}
