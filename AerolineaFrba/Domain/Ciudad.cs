using System;

namespace AerolineaFrba
{
	public class Ciudad
	{
        public int Cod_Ciudad { get; set; }
        public string Nombre_Ciudad { get; set; }
        public bool Estado_Ciudad { get; set; }

		public Ciudad ( String Nombre_Ciudad, int Cod_Ciudad, bool Estado_Ciudad )
		{
            this.Nombre_Ciudad = Nombre_Ciudad;
            this.Cod_Ciudad = Cod_Ciudad;
            this.Estado_Ciudad = Estado_Ciudad;		
        }

        public override string ToString()
        {
            return Nombre_Ciudad;
        }

        public static Ciudad Copy(Ciudad a)
        {
            return new Ciudad( a.Nombre_Ciudad, a.Cod_Ciudad, a.Estado_Ciudad );
        }

	}
}

