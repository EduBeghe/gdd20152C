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
	}
}

