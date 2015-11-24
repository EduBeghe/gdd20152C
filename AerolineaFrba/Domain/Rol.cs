using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Rol
    {
        public string nombre { get; set; }
        public int estado { get; set; }
        
        public Rol( string nombre, int estado )
        {
            this.nombre = nombre;
            this.estado = estado;
        }
    }
}
