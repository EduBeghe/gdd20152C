﻿using System;

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

	}
}

