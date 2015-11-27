using System;

namespace AerolineaFrba
{
	public class TarjetaDeCredito
	{
        public int Numero_Tarjeta { get; set; }
        public int Cod_Seg { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        // Tipo de tarjeta no es una clase ? 
        public string Tipo_Tarjeta { get; set; }
        public Cliente cliente { get; set; }

        public int dni { get; set; }

		public TarjetaDeCredito( int Numero_Tarjeta, int Cod_Seg, DateTime Fecha_Vencimiento, string Tipo_Tarjeta, Cliente cliente )
		{
            this.Numero_Tarjeta = Numero_Tarjeta;
            this.Cod_Seg = Cod_Seg;
            this.Fecha_Vencimiento = Fecha_Vencimiento;
            this.Tipo_Tarjeta = Tipo_Tarjeta;
            this.cliente = cliente;
t		}
	}
}

