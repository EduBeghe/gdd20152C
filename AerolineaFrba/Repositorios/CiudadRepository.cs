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

		public Ciudad getCiudad( int Cod_Ciudad )
		{
			return parse ( DBAdapter.retrieveDataTable("GetCiudad" ).Rows[0]);
		}


				
        public List<Ciudad> parseCiudades ( DataTable dataTable )
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Ciudad parse(DataRow dr)
        {
            return new Ciudad( 
            	dr["Nombre_Ciudad"] as string,
                Convert.ToInt32(dr["Cod_Ciudad"]),
            	( bool ) dr["Estado_Ciudad"]
            );
        }


	}
}