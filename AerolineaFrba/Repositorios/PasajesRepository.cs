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

		public void cancelarPasaje( Pasaje pasaje )
		{
			Adapter.executeProcedure("Cancelar_Pasajes",
				pasaje.viaje.fechaSalida,
				pasaje.viaje.aeronave.idAeronave,
				pasaje.viaje.rutaAerea.idRutaAerea,
				// motivo 
			);
		}

		
		public List<Pasaje> parsePasajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Pasaje parse(DataRow dr)
        {
       		return new Pasaje( Convert.ToInt32(dr["Cod_Pasaje"] ),
       			// Verificar tipo de datos de dr[ "Cliente_apellido" ]
       		new ClientesRepository.getCliente( Convert.ToInt32(dr["Nro_Dni"]), dr["Cliente_Apellido"] ),
			new ViajesRepository.getViaje( Convert.ToInt32(dr["Cod_Viaje"]) ),
			// Terminar cuando esten los atributos de Pasaje definidos!
			);
        }

	}
}