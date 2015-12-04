using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Repositories {

	class UsuarioRepository {

		public int login( string usuario, string pass )
		{
			return DBAdapter.executeProcedureWithReturnValue("Validar_Login", usuario, pass );

		}

	}
}