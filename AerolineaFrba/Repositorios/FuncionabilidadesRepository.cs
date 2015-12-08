using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class FuncionalidadesRepository {

		public Funcionalidades getFuncionalidad( int idFuncionalidad )
		{
			return parse ( DBAdapter.retrieveDataTable("GetFuncionalidad", idFuncionalidad ).Rows[0]);
		}

		public List<Funcionalidades> getFuncionalidades()
		{
			return parseFuncionalidades( DBAdapter.retrieveDataTable("Get_Funcionalidades"));
		}

		public List<Funcionalidades> getFuncionalidadesByRol( int CodRol ){
			return parseFuncionalidades( DBAdapter.retrieveDataTable("Get_Funcionalidades_De_Rol", codRol ));
		}

		public List<Funcionalidades> parseFuncionalidades( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Funcionalidades parse(DataRow dr)
        {
        	return new Funcionalidades(
        		Convert.ToInt32(dr["Cod_Funcionalidad"]),
        		dr["Nombre_Funcionalidad"] as string
       		);
        }


	}
}