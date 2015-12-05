using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Fabricante
    {
        public int Cod_Fabricante { get; set; }
        public string Nombre_Fabricante { get; set; }

        public Fabricante(int Cod_Fabricante, string Nombre_Fabricante)
        {
            this.Cod_Fabricante = Cod_Fabricante;
            this.Nombre_Fabricante = Nombre_Fabricante;
        }

        public override string ToString()
        {
            return Nombre_Fabricante;
        }
    }
}
