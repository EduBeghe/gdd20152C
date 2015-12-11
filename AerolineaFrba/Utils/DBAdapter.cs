using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Utils
{
    class DBAdapter
    {
        /// Realiza la conexion a la base de datos.
        public static void conexionSql(SqlConnection cn, SqlCommand cm)
        {
            try
            {
                string sconcompleto = CLC_SessionManager.connectionString;
                cn.ConnectionString = sconcompleto;
                cm.Connection = cn;
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception en conexionSql connection");
                throw;
            }
        }
        
        /// Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        public static DataTable retrieveDataTable(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _retrieveDataTable(procedure, argumentos, values);
        }

        /// Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        public static DataTable retrieveDataTable(string procedure)
        {
            return _retrieveDataTable(procedure, null, null);
        }

        /// Ejecuta un stored procedure.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        public static void executeProcedure(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            _executeProcedure(procedure, argumentos, values);
        }

        /// Ejecuta un stored procedure.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        public static void executeProcedure(string procedure)
        {
            _executeProcedure(procedure, null, null);
        }

        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _checkIfExists(procedure, argumentos, values);
        }

        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure)
        {
            return _checkIfExists(procedure, null, null);
        }

        /// Ejecuta un stored procedure que devuelve un valor númerico y retorna dicho valor.
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> Valor de retorno del stored procedure.</returns>
        public static int executeProcedureWithReturnValue(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }


        private static void _executeProcedure(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "TODOX2LUCAS." + procedure;

                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                cm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ejecutar el procedimiento almacenado " + cm.CommandText);
                throw;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _checkIfExists(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "TODOX2LUCAS." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                dr = cm.ExecuteReader();
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception en checkIfExist connection");
                throw;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static int _executeProcedureWithReturnValue(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "TODOX2LUCAS." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                cm.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                cm.ExecuteNonQuery();
                return (int)cm.Parameters["@RETURN_VALUE"].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Exception en _executeProcedureWithReturnValue connection");
                throw;
                //return -1;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static DataTable _retrieveDataTable(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "TODOX2LUCAS." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                dr = cm.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Exception en _retrieveDataTable connection");
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static List<string> _generateArguments(string procedure)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();
            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.Text;
                var command = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='TODOX2LUCAS' AND SPECIFIC_NAME='" + procedure + "'";
                cm.CommandText = command;
                dr = cm.ExecuteReader();
                dt.Load(dr);
                //if (dr == null) MessageBox.Show("dr es null ");
                //else if ( dr.HasRows) MessageBox.Show("dr TIENE FILAS"); 
                foreach (DataRow d in dt.Rows)
                {
                    args.Add(d[0].ToString());
                }
                return args;
            }
            catch (Exception)
            {
                MessageBox.Show("Exception en _generateArguments connection");
                throw;
                //return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, SqlCommand cm, params object[] values)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }
    }   
}
