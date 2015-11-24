using System;

namespace AerolineaFrba
{
	public class RutaAerea
	{
		public int idRutaAerea { get; set; }
		public Ciudad origen { get; set; }
        public Ciudad destino { get; set; }
        public TipoServicio servicio { get; set; }
        public double precioXKg { get; set; }
        public double precioXPasaje { get; set; }

		public RutaAerea ( int idRutaAerea, Ciudad origen, Ciudad destino, TipoServicio servicio, double precioXKg, double precioXPasaje )
		{
            this.idRutaAerea = idRutaAerea;
            this.origen = origen;
            this.destino = destino;
            this.servicio = servicio;
            this.precioXKg = precioXKg;
		}
	}
}

