using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories
{
    class ProductoRepository
    {
        public ProductoCanje getProducto(int codProducto)
        {
            return parse(DBAdapter.retrieveDataTable("Get_Producto", codProducto).Rows[0]);
        }

        public List<ProductoCanje> getProductos()
        {
            return parseProductos(DBAdapter.retrieveDataTable("Get_Productos"));
        }

        public List<ProductoCanje> parseProductos(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }



        public ProductoCanje parse(DataRow dr)
        {
            return new ProductoCanje(
                Convert.ToInt32(dr["Cod_Producto"]),
                dr["Descripcion_Producto"] as string,
                Convert.ToInt32(dr["Cantidad"]),
                Convert.ToInt32(dr["PrecioEnMillas"])
            );
        }


    }
}
