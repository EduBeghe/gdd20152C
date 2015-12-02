using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using System.Data;


namespace AerolineaFrba.Repositories {

	class PasajesRepository {

		// Forma de pago ?
		// Deberia entrar como parametro la tarjeta o cliente tiene una forma
		// de referenciar su propia tarjeta ?
		public void comprarPasajes( Pasaje pasaje, Cliente cliente, TarjetaDeCredito tarjeta )
		{
			DBAdapter.executeProcedure("Comprar_Pasajes",
				pasaje.Butaca_Asociada,
				pasaje.viaje.Cod_Viaje,
				cliente.Cliente_Apellido,
				cliente.Nro_Dni,
				// Forma de pago ( viene del form ? ) ( otra opcion que no sea tarjeta ? )
				tarjeta.Numero_Tarjeta,
				tarjeta.Cod_Seg,
				tarjeta.Fecha_Vencimiento,
				tarjeta.Tipo_Tarjeta
			);
		}

		public void cancelarPasaje( Pasaje pasaje, DateTime fecha )
		{
			DBAdapter.executeProcedure("Cancelar_Pasajes",
				fecha,
				pasaje.viaje.aeronave.Cod_Aeronave,
				pasaje.viaje.rutaAerea.Cod_Ruta,
				// motivo ( de la form ? ) 
			);
		}

		
		public List<Pasaje> parsePasajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Pasaje parse(DataRow dr)
        {
       		return new Pasaje( 
       		Convert.ToInt32(dr["Cod_Pasaje"] ),
       		Convert.ToDateTime(dr["Fecha_Viaje"]),
       		new ViajesRepository().getViaje( Convert.ToInt32(dr["Cod_Viaje"])),
       		Convert.ToInt32(dr["Butaca_Asociada"]),
       		new ClientesRepository().getCliente( Convert.ToInt32(dr["Nro_Dni"]), dr["Cliente_Apellido"] as string ),
       		Convert.ToInt32(dr["Pasaje_Precio"])
 			);
        }

	}
}