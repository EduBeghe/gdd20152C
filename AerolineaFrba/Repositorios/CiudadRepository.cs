using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class CiudadRepository {

		public void darDeAlta(  string nombre )
		{
			DBAdapter.executeProcedure("Alta_Ciudad",  nombre );
		}

		public void modificarNombre(  Ciudad ciudad, string nombre )
		{
			DBAdapter.executeProcedure("Modificar_Nombre_Ciudad", 
			ciudad.Nombre_Ciudad,
			nombre 
			);				
		}

		public void darDeBaja(  Ciudad ciudad )
		{
			DBAdapter.executeProcedure("Baja_Ciudad", ciudad.Nombre_Ciudad );				
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