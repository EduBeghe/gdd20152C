using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class Modelo
    {
        public int Cod_Modelo { get; set; }
        public string Descricpion_Modelo { get; set; }

        public Modelo(String Descricpion_Modelo, int Cod_Modelo )
		{
            this.Descricpion_Modelo = Descricpion_Modelo;
            this.Cod_Modelo = Cod_Modelo;
        }

        public override string ToString()
        {
            return Descricpion_Modelo;
        }
    }
}
