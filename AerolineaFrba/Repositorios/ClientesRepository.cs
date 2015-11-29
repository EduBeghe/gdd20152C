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
            cliente.Cliente_Telefono,
            );
        }

        public Cliente getCliente( int dni, string apellido )
        {
            return parse ( DBAdapter.retrieveDataTable("GetCliente", dni, apellido ).Rows[0]);
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
            cliente.Cliente_Telefono,
            );
        }

        internal int getMillas( Cliente cliente )
        {
            // Verificar tipo de retorno y que llamada a DBA
            return DBAdapter.executeProcedureWithReturnValue("Consulta_Millas",
                cliente.Nro_Dni,
                cliente.Cliente_Apellido,
                );
        }

        // 
        public void canjeMillas( Cliente cliente, ProductoCanje producto, int cantidad  )
        {
            DBAdapter.executeProcedure( "Canjear_Millas", 
            cliente.Nro_Dni,
            cliente.Cliente_Apellido,
            producto.Cod_Producto
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


        /* 
        public List<Cliente> findClientes(string nombre, string apellido, TipoDocumento tipo_doc, string mail, int? nro_doc)
        {
            return parseClientes(DBAdapter.retrieveDataTable("find_clientes", nombre, apellido, tipo_doc.ID, mail, nro_doc));
        }

        public List<Cliente> getClientes()
        {
            return parseClientes(DBAdapter.retrieveDataTable("getCliente", DBNull.Value));
        }

        public Cliente getCliente(int ID)
        {
            return parse(DBAdapter.retrieveDataTable("getCliente", ID).Rows[0]);
        }

        public Cliente getClienteByUserId(int uID)
        {
            return parse(DBAdapter.retrieveDataTable("getClienteByUserId", uID).Rows[0]);
        }

        private List<Cliente> parseClientes(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        private Cliente parse(DataRow dr)
        {
            return new Cliente(Convert.ToInt32(dr["ID"]),
                               dr["Nombre"] as string,
                               dr["Apellido"] as string,
                               new Documento(getTipoDoc(Convert.ToInt32(dr["Tipo_Documento"])), Convert.ToInt64(dr["Nro_Doc"])),
                               dr["Mail"] as string,
                               new Domicilio(dr["Dom_Calle"] as string, Convert.ToInt32(dr["Dom_Nro"]), dr["Dom_Depto"] as string, Convert.ToInt32(dr["Dom_Piso"]), dr["Localidad"] as string, new PaisRepository().getPais(Convert.ToInt32(dr["Pais"]))),
                               new PaisRepository().getPais(Convert.ToInt32(dr["Nacionalidad"])),
                               Convert.ToDateTime(dr["Fecha_nac"]),
                               (Boolean)dr["Estado"]);
        }

        public static bool coincideDocumento(long tipo, string documento)
        {
            return DBAdapter.checkIfExists("COINCIDE_DOCUMENTO", tipo, documento);
        }

        private TipoDocumento getTipoDoc(int p)
        {
            DataRow tipo = DBAdapter.retrieveDataTable("getTipoDoc", p).Rows[0];
            return new TipoDocumento(Convert.ToInt32(tipo["ID"]), tipo["Descripcion"] as string);
        }

        
        */
    }

}

