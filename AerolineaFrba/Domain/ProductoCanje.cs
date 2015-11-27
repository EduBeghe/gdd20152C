using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class ProductoCanje
    {
        public int Cod_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public int Cantidad { get; set; }

        public ProductoCanje( int Cod_Producto, string Descripcion_Producto, int Cantidad )
        {
            this.Cod_Producto = Cod_Producto;
            this.Descripcion_Producto = Descripcion_Producto;
            this.Cantidad = Cantidad;
        }
    }
}
