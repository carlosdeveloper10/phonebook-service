/*
* Copyright (c) Carlos Mario.
* Please, read the document https://github.com/carlosprogrammer/phonebook-service/blob/master/LICENSE
* of this code
*
*
*
*
*
*
*
*
* 
* 
* <carlos_programmer10@hotmail.com>
*/




using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmsoft.CloudDBConnection
{
    /// <summary>
    /// One simple class that provides objects to connect with Sql server data base
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class Connection
    {
        #region "The attributes region"

        /// <summary>
        /// The sql statement
        /// </summary>
        private String _strSQL;

        /// <summary>
        /// Connection object
        /// </summary>
        private SqlConnection _objConnetion;

        /// <summary>
        /// Rows affected by any UPDATE, INSERT or DELETE sql statement
        /// </summary>
        private int _intRowsAffected;

        /// <summary>
        /// Result (table) by a SELECT statement
        /// </summary>
        private SqlDataReader _objResult;

        /// <summary>
        /// Command action on data base
        /// </summary>
        private SqlCommand _objCommand;

        #endregion


        #region "The constructors region"

        public Connection()
        {
            this._objConnetion = new SqlConnection();
            this._objCommand = new SqlCommand();
        }
        #endregion


        #region "The properties region"
        /// <summary>
        /// Estanle la sentencia Sql que se va a ejecutar en la base datos
        /// </summary>
        public string Sql
        {
            set { _strSQL = value; }
        }

        /// <summary>
        /// Obtiene un grupo de filas y columnas que representan el valor de una consulta
        /// </summary>
        public SqlDataReader Result
        {
            get { return _objResult; }
        }

        /// <summary>
        /// Obtiene el numero de filas afectadas por una consulta DELETE, UPDATE Y INSERT
        /// </summary>
        public int RowsAffected
        {
            get { return _intRowsAffected; }
        }


        #endregion

        #region "The public functions and methods region"

        /// <summary>
        /// Opens the connection
        /// </summary>
        /// <returns>
        /// Returns true if the connection is established or false
        /// if the connection isn't established
        /// </returns>
        public bool Open()
        {
            
            this._objConnetion.ConnectionString = "It is waiting";

            try
            {
                this._objConnetion.Open();
                return true;
            }
            catch (ConnectionException exc)
            {
                return false;
            }
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public void Close()
        {
            try
            {
                _objConnetion.Close(); //cierra la conexion
                _objConnetion = null; //elimina el objeto connection
            }
            catch (ConnectionException exc)
            {
            }
        }

        /// <summary>
        /// Executes a SELECT statement
        /// </summary>
        /// <returns>
        /// Returns the result(table) of the statement.
        /// The values is of the type SqlDataReader
        /// </returns>
        public SqlDataReader ExecuteQuery()
        {
            try
            {

                _objCommand.Connection = _objConnetion;
                _objCommand.CommandText = _strSQL;
                _objCommand.CommandType = CommandType.Text;
                _objResult = _objCommand.ExecuteReader();

            }
            catch (ConnectionException exc)
            {
                new ConnectionException(exc.Message + " [No se pudo finalizar la sentencia 'UPDATE']");
            }

            return _objResult;
        }


        /// <summary>
        /// Executes the INSERT, UPDATE or DELETE statement and returns the number
        /// of rows affected
        /// </summary>
        /// <returns>
        /// The number of rows affected by the statement UPDATE.
        /// </returns>
        public int ExecuteUpdate()
        {

            try
            {

                this._objCommand.Connection = this._objConnetion;
                this._objCommand.CommandText = this._strSQL;
                this._objCommand.CommandType = CommandType.Text;
                this._intRowsAffected = this._objCommand.ExecuteNonQuery();

            }
            catch (ConnectionException exc)
            {
                new ConnectionException(exc.Message + " [No se pudo finalizar la sentencia 'QUERY']");
            }

            return this._intRowsAffected;
        }

        #endregion
    }
}
