using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    class Fabricante
    {
        public int idFabricante { get; set; }
        public string nombre { get; set; }

        public Fabricante(int idFabricante, string nombre)
        {
            this.idFabricante = idFabricante;
            this.nombre = nombre;
        }
    }
}
