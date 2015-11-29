using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class FabricantesRepository {


		public Fabricante getFabricante( int codFabricante )
		{
			return parse ( DBAdapter.retrieveDataTable("GetFabricante", codFabricante ).Rows[0]);
		}


		public Fabricante parse(DataRow dr)
        {
       		return new Fabricante( 
       			Convert.ToInt32(dr["Cod_Fabricante"]),
       			dr["Nombre_Fabricante"] as string
     		);
        }



	}
}