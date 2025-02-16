using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Utilities.Config;

namespace Database;

public static class DatabaseManager
{
    private static readonly string ConnectionString = AppConfig.ConnectionString;

    /// <summary>
    /// Ensures that the ConnectionString property has been initialized.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    static DatabaseManager()
           {
               if (string.IsNullOrEmpty(ConnectionString))
               {
                   throw new InvalidOperationException("The ConnectionString property has not been initialized.");
               }
           }
    /// <summary>
    /// Executes a non-query command (e.g., INSERT, UPDATE, DELETE).
    /// </summary>
    public static int ExecuteNonQuery(DBCommandParams cmdParams)
    {
        return ExecuteCommand(cmdParams, cmd => cmd.ExecuteNonQuery());
    }

    /// <summary>
    /// Executes a scalar query (e.g., SELECT COUNT(*)) and returns the first column of the first row.
    /// </summary>
    public static object ExecuteScalar(DBCommandParams cmdParams)
    {
        return ExecuteCommand(cmdParams, cmd => cmd.ExecuteScalar());
    }

    /// <summary>
    /// Executes a query and returns the results as a DataTable.
    /// </summary>
    public static DataTable ExecuteDataTable(DBCommandParams cmdParams)
    {
        return ExecuteCommand(cmdParams, cmd =>
        {
            using (var adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        });
    }

    /// <summary>
    /// Generic method to execute a command and return a result.
    /// </summary>
    private static T ExecuteCommand<T>(DBCommandParams cmdParams, Func<SqlCommand, T> action)
    {
        using (var connection = new SqlConnection(ConnectionString))
        using (var command = new SqlCommand(cmdParams.Sql, connection) { CommandType = cmdParams.CommandType })
        {
            if (cmdParams?.Parameters != null)
            {
                foreach (var parameter in cmdParams.Parameters)
                {
                    command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value ?? DBNull.Value));
                }
            }

            try
            {
                connection.Open();
                return action(command);
            }
            catch (Exception ex)
            {
                LogError($"DatabaseManager Error: {ex.Message}", ex);
                throw; // Re-throw the exception after logging
            }
        }
    }
 
    /// <summary>
    /// Logs errors to a proper logging system (replace with a real logger in production).
    /// </summary>
    private static void LogError(string message, Exception exception)
    {
        // Replace this with a proper logging framework (e.g., Serilog, NLog)
        Debug.WriteLine($"{message}\n{exception}");
    }
}
