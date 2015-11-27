using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	// POSIBLEMENTE NO SEA NECESARIO HACERLO 
	class CiudadRepository {

		public void darDeAlta(  RutaAerea rutaAerea )
		{
			//DBAdapter.executeProcedure("XXXX", 
			//);
		}

		public void modificar(  RutaAerea rutaAerea )
		{
			//DBAdapter.executeProcedure("XXXXX", cliente.idCliente);				
		}

		public void darDeBaja(  RutaAerea rutaAerea )
		{
			//Adapter.executeProcedure("XXXX", cliente.idCliente);				
		}

				
        public List<Cliente> parseClientes ( DataTable dataTable )
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Cliente parse(DataRow dr)
        {
            return new Cliente( Convert.ToInt32(dr["Nro_Dni"]), dr["Cliente_Apellido"] 
            // Terminar cuando esten los atributos de Cliente definidos!
            );
        }


	}
}