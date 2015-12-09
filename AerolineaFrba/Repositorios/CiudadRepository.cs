using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class CiudadRepository {

		public int darDeAlta(  string nombre )
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Ciudad",  nombre );
            return retorno;
		}

		public int modificarNombre(  Ciudad ciudad, string nombre )
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Nombre_Ciudad", 
			ciudad.Nombre_Ciudad,
			nombre 
			);
            return retorno;
		}

		public void darDeBaja(  Ciudad ciudad )
		{
			DBAdapter.executeProcedure("Baja_Ciudad", ciudad.Nombre_Ciudad );				
		}

		public List<Ciudad> findCiudad(  string nombre  )
		{
			return parseCiudades( DBAdapter.retrieveDataTable("Filtrar_Ciudades", nombre ));	
		}

		public Ciudad getCiudad( int codigo )
		{
			return parse ( DBAdapter.retrieveDataTable("GetCiudad", codigo  ).Rows[0]);
		}

		public List<Ciudad> getCiudades()
		{
			return parseCiudades( DBAdapter.retrieveDataTable("GetCiudades" ) );
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