using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class PasajesRepository {

		// Forma de pago ?
		// Deberia entrar como parametro la tarjeta o cliente tiene una forma
		// de referenciar su propia tarjeta ?
		public void comprarPasajes( Pasaje pasaje, Cliente cliente )
		{
			Adapter.executeProcedure("Comprar_Pasajes",
				pasaje.butaca.idButaca,
				pasaje.viaje.idViaje,
				cliente.apellido,
				cliente.dni,
				// Forma de pago
				// numero de Tarjeta
				// codigo de seguridad
				// fecha de vencimiento
				// tipo de tarjeta 
			);
		}


	}
}