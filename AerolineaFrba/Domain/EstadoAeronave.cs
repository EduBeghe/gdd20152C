using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class EstadoAeronave
    {
        public int idEstado { get; set; }
        public DateTime fechaReinicio { get; set; }
        public DateTime fechaFuera { get; set; }

        public EstadoAeronave(int idEstado, DateTime fechaReinicio, DateTime fechaFuera)
        {
            this.idEstado = idEstado;
            this.fechaFuera = fechaFuera;
            this.fechaReinicio = fechaReinicio;
        }
    }
}
