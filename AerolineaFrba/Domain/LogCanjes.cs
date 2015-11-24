using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class LogCanjes
    {
        public ProductoCanje productoCanje { get; set; }
        public int dni { get; set; }
        public int cantidadProducto { get; set; }
        public DateTime fechaCanje { get; set; }

        public LogCanjes( ProductoCanje productoCanje, int dni, int cantidadProducto, DateTime fechaCanje )
        {
            this.productoCanje = productoCanje;
            this.dni = dni;
            this.cantidadProducto = cantidadProducto;
            this.fechaCanje = fechaCanje;
        }
    }
}
