using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;

namespace AerolineaFrba.Repositories
{

    class ClientesRepository
    {

        internal void darDeBaja(Cliente cliente)
        {
            // DBAdapter.executeProcedure("Baja_Cliente", cliente.idCliente);
        }

        internal void modificar(Cliente cliente)
        {
            DBAdapter.executeProcedure("Modificar_Datos_Cliente",
            cliente.Nro_Dni,
            cliente.Cliente_Apellido,
            cliente.Cliente_Nombre,
            cliente.Cliente_Direccion,
            cliente.Cliente_Mail,
            cliente.Cliente_Fecha_Nacimiento,
            cliente.Cliente_Telefono
            );
        }

        public Cliente getCliente( int dni, string apellido )
        {
           return  parse (DBAdapter.retrieveDataTable("GetCliente", dni, apellido ).Rows[0]);
            
        }


        internal void darDeAlta( Cliente cliente )
        {
            DBAdapter.executeProcedure("Alta_Cliente",
            cliente.Nro_Dni,
            cliente.Cliente_Apellido,
            cliente.Cliente_Nombre,
            cliente.Cliente_Direccion,
            cliente.Cliente_Mail,
            cliente.Cliente_Fecha_Nacimiento,
            cliente.Cliente_Telefono
            );
        }

        internal int getMillas( Cliente cliente )
        {
            return DBAdapter.executeProcedureWithReturnValue("Consulta_Millas",
                cliente.Nro_Dni,
                cliente.Cliente_Apellido
                );
        }

        // 
        public int canjeMillas( Cliente cliente, ProductoCanje producto, int cantidad  )
        {
            return DBAdapter.executeProcedureWithReturnValue( "Canjear_Millas", 
            cliente.Nro_Dni,
            cliente.Cliente_Apellido,
            producto.Descripcion_Producto,
            cantidad
            );
        }

        public List<Cliente> parseClientes ( DataTable dataTable )
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Cliente parse(DataRow dr)
        {
            return new Cliente( 
            Convert.ToInt32(dr["Nro_Dni"]), 
            dr["Cliente_Nombre"] as string,
            dr["Cliente_Apellido"] as string,
            dr["Cliente_Direccion"] as string,
            Convert.ToInt32(dr["Cliente_Telefono"]), 
            dr["Cliente_Mail"] as string,
            Convert.ToDateTime(dr["Cliente_Fecha_Nacimiento"]),
            Convert.ToInt32(dr["Cant_Millas"])
            );
        }

    }

}

