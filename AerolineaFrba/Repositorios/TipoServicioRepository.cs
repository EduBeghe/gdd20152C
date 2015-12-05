using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class TipoServicioRepository {


		public TipoServicio getTipoServicio( int codTipoServicio )
		{
			return parse ( DBAdapter.retrieveDataTable("GetTipoServicio", codTipoServicio ).Rows[0]);
		}

		public List<TipoServicio> getServicios()
		{
			return parseServicios( DBAdapter.retrieveDataTable("getServicios" ) );
		}

		public List<TipoServicio> parseServicios( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}



		public TipoServicio parse(DataRow dr)
        {
       		return new TipoServicio( 
       			Convert.ToInt32(dr["Cod_Tipo_Servicio"]),
       			dr["Descripcion_Servicio"] as string,
    			Convert.ToInt32(dr["Precio_Servicio"])
     		);
        }



	}
}