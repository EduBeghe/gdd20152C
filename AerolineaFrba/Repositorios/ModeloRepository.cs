using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Utils;
using AerolineaFrba.Domain;
using System.Data;

namespace AerolineaFrba.Repositories
{
    class ModeloRepository
    {

        public Modelo getModelo( int idModelo ) 
        {
            return parse(DBAdapter.retrieveDataTable("GetModelo", idModelo).Rows[0]);
        }

        public List<Modelo> parseModelos(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Modelo parse( DataRow dr)
        {
            return new Modelo(
       			dr["Descricpion_Modelo"] as string,
                Convert.ToInt32(dr["Cod_Modelo"])
                );
        }


    }
}
