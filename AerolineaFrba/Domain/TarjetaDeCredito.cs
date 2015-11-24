using System;

namespace AerolineaFrba
{
	public class TarjetaDeCredito
	{
        public int numeroTarjeta { get; set; }
        public int codigoSeguridad { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public TipoTarjeta tipoTarjeta { get; set; }
        public int dni { get; set; }

		public TarjetaDeCredito( int numeroTarjeta, int codigoSeguridad, DateTime fechaVencimiento, TipoTarjeta tipoTarjeta, int dni )
		{
            this.numeroTarjeta = numeroTarjeta;
            this.codigoSeguridad = codigoSeguridad;
            this.fechaVencimiento = fechaVencimiento;
            this.tipoTarjeta = tipoTarjeta;
            this.dni = dni;
		}
	}
}

