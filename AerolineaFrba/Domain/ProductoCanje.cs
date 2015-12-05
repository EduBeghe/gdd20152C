using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class ProductoCanje
    {
        private int p1;
        private string p2;
        private int p3;
        private int p4;

        public int Cod_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public int Cantidad { get; set; }
        public int PrecioEnMillas { get; set; }

        public ProductoCanje( int Cod_Producto, string Descripcion_Producto, int Cantidad )
        {
            this.Cod_Producto = Cod_Producto;
            this.Descripcion_Producto = Descripcion_Producto;
            this.Cantidad = Cantidad;
            this.PrecioEnMillas = PrecioEnMillas;
        }

        public ProductoCanje(int p1, string p2, int p3, int p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }
}
