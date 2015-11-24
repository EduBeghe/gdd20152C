using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Estado
    {
        public int idEstado { get; set; }
        public DateTime fechaReinicio { get; set; }
        public DateTime fechaFuera { get; set; }

        public Estado(int idEstado, DateTime fechaReinicio, DateTime fechaFuera)
        {
            this.idEstado = idEstado;
            this.fechaFuera = fechaFuera;
            this.fechaReinicio = fechaReinicio;
        }
    }
}
