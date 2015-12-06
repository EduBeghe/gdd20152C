using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class TipoServicio
    {
        public int Cod_Tipo_Servicio { get; set; }
        public string Descripcion_Servicio { get; set; }
        public int Precio_Servicio { get; set; }

        public TipoServicio(int Cod_Tipo_Servicio, string Descripcion_Servicio, int Precio_Servicio )
        {
            this.Cod_Tipo_Servicio = Cod_Tipo_Servicio;
            this.Descripcion_Servicio = Descripcion_Servicio;
            this.Precio_Servicio = Precio_Servicio;
        }

        public override string ToString()
        {
            return Descripcion_Servicio;
        }
        
    }
}
