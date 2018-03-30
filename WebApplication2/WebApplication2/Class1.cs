using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLDB
/// </summary>
public static class SQLHelper
{
    //"GearHostSqlServer";
    //"LocalSqlServer";
    //based on https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand(v=vs.110).aspx

    private static String ConnString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GearHostSqlServer"].ConnectionString;

    public static SqlDataReader ExecuteQuery(String query, CommandType commandType = CommandType.Text, params SqlParameter[] sqlParams)
    {
        SqlConnection conn = new SqlConnection(ConnString);

        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(sqlParams);

            conn.Open();
            // When using CommandBehavior.CloseConnection, the connection will be closed when the 
            // IDataReader is closed.
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader; //must be closed
        }
    }

   
    public static SqlDataReader ExecuteQueryStoreProcedure(String query, CommandType commandType = CommandType.StoredProcedure, params SqlParameter[] sqlParams)
    {
        SqlConnection conn = new SqlConnection(ConnString);

        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(sqlParams);

            conn.Open();
            // When using CommandBehavior.CloseConnection, the connection will be closed when the 
            // IDataReader is closed.
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return reader; //must be closed
        }
    }

    // Set the connection, command, and then execute the command with non query.
    public static Int32 ExecuteNonQuery(String Query,
        CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                // type is only for OLE DB.  
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }

    // Set the connection, command, and then execute the command and only return one value.
    public static Object ExecuteScalar(String Query,
        CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(ConnString))
        {
            using (SqlCommand cmd = new SqlCommand(Query, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }

}