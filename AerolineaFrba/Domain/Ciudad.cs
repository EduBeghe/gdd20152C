using System;

namespace AerolineaFrba
{
	public class Ciudad
	{
        public String nombre { get; set; }
        public int idCiudad { get; set; }

		public Ciudad ( String nombre, int idCiudad )
		{
            this.nombre = nombre;
            this.idCiudad = idCiudad;
		}
	}
}

