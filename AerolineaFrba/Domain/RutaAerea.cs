using System;
using AerolineaFrba.Domain;
using AerolineaFrba.Repositories;

namespace AerolineaFrba
{
	public class RutaAerea
	{
		public int Cod_Ruta { get; set; }
		public Ciudad origen { get; set; }
        public Ciudad destino { get; set; }
        public TipoServicio servicio { get; set; }
        public int Precio_Base_Pasaje { get; set; }
        public int Precio_Base_Kg { get; set; }
        public bool Estado_Ruta  { get; set; }

		public RutaAerea ( int Cod_Ruta, Ciudad origen, Ciudad destino, TipoServicio servicio, int Precio_Base_Pasaje, int Precio_Base_Kg, bool Estado_Ruta )
		{
            this.Cod_Ruta = Cod_Ruta;
            this.origen = origen;
            this.destino = destino;
            this.servicio = servicio;
            this.Precio_Base_Pasaje = Precio_Base_Pasaje;
            this.Precio_Base_Kg = Precio_Base_Kg;
            this.Estado_Ruta = Estado_Ruta;
		}

        public override string ToString()
        {
            return origen.Nombre_Ciudad + "-" + destino.Nombre_Ciudad + "(" + servicio.Descripcion_Servicio + ")";
        }

        public static RutaAerea Copy(RutaAerea a)
        {
            // Boolean copyEstdo = c.estado;
            return new RutaAerea ( 
                a.Cod_Ruta,
                new Ciudad( a.origen.Nombre_Ciudad, a.origen.Cod_Ciudad, a.origen.Estado_Ciudad ),
                new Ciudad ( a.destino.Nombre_Ciudad, a.destino.Cod_Ciudad, a.destino.Estado_Ciudad ),
                new TipoServicio( a.servicio.Cod_Tipo_Servicio, a.servicio.Descripcion_Servicio, a.servicio.Precio_Servicio ),
                a.Precio_Base_Pasaje,
                a.Precio_Base_Kg,
                a.Estado_Ruta
                );
        }


	}
}

