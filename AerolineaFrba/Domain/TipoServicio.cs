using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class TipoServicio
    {
        public int idTipoServicio { get; set; }
        public string nombreTipoServicio { get; set; }

        public TipoServicio(int idTipoServicio, string nombreTipoServicio)
        {
            this.idTipoServicio = idTipoServicio;
            this.nombreTipoServicio = nombreTipoServicio;
        }
    }
}
