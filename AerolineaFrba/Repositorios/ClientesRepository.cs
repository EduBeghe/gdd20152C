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
            //cliente.idCliente,
            cliente.dni,
            cliente.apellido,
            cliente.nombre,
            cliente.direccion,
            cliente.email,
            cliente.fechaNacimimento,
            cliente.telefono,
            );
        }

        internal void darDeAlta( Cliente cliente )
        {
            return DBAdapter.executeProcedure("Alta_Cliente",
            //cliente.idCliente,
            cliente.dni,
            cliente.apellido,
            cliente.nombre,
            cliente.direccion,
            cliente.email,
            cliente.fechaNacimimento,
            cliente.telefono
            );
        }

        internal int getMillas( Cliente cliente )
        {
            return DBAdapter.executeProcedureWithReturnValue("Consulta_Millas",
                cliente.dni,
                cliente.apellido,
                );
        }

        // 
        public void canjeMillas( Cliente cliente, ProductoCanje producto, int cantidad  )
        {
            DBAdapter.executeProcedure( "Canjear_Millas", 
            cliente.dni,
            cliente.apellido,
            producto.idProducto
            cantidad
            );
        }

        public List<Cliente> parseClientes ( DataTable dataTable )
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Cliente parse(DataRow dr)
        {
            return new Cliente( Convert.ToInt32(dr["Nro_Dni"]), dr["Cliente_Apellido"] 
            // Terminar cuando esten los atributos de Cliente definidos!
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

