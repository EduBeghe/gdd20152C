using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Funcionalidades
    {
        public int Cod_Funcionalidad { get; set; }
        public string Nombre_Funcionalidad { get; set; }

        public Funcionalidades( int Cod_Funcionalidad, string Nombre_Funcionalidad )
        {
            this.Cod_Funcionalidad = Cod_Funcionalidad;
            this.Nombre_Funcionalidad = Nombre_Funcionalidad;
        }

        public override string ToString()
        {
            return Nombre_Funcionalidad;
        }

    }
}
