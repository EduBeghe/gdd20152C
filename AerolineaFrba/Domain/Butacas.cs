using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Butacas
    {
        // no falta el id ? 
        public Aeronave aeronave { get; set; }
        public string ubicacion { get; set; }
        public TipoServicio tipoServicio { get; set; }
        public int estadoButaca { get; set; }

        public Butacas( Aeronave aeronave, string ubicacion, TipoServicio tipoServicio, int estadoButaca )
        {
            this.aeronave = aeronave;
        	this.ubicacion = ubicacion;
        	this.tipoServicio = tipoServicio;
        	this.estadoButaca = estadoButaca;
        }
    }
}
