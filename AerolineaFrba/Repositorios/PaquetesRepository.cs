using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Repositories {

	class EncomiendasRepository {

		public void cancelarPaquete(  Encomienda encomienda, string motivo )
		{
			DBAdapter.executeProcedure("Cancelar_Paquetes",
				encomienda.viaje.aeronave.Cod_Aeronave,
				encomienda.viaje.rutaAerea.Cod_Ruta,
				motivo
			);
		}

        public int comprarPaquete(int kgs, int codViaje, string apellido, int dni, string formaPago, long numeroTarjeta, int codSeg, DateTime vencimiendo, string tipoTarjeta)
        {
            return DBAdapter.executeProcedureWithReturnValue("Comprar_Encomienda",
                kgs, codViaje, apellido, dni, formaPago, numeroTarjeta, codSeg, vencimiendo, tipoTarjeta);
        }
	}
}