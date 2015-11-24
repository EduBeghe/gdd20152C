using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class ProductoCanje
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }

        public ProductoCanje( int idProducto, string nombre, int stock )
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.stock = stock;
        }
    }
}
