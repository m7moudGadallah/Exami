using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Utilities.Config;
using Database.DBCommandParams;


namespace Database;

public class DbContext
{
    private static DbContext _instance = null;
    private readonly string _connectionString = AppConfig.ConnectionString;

    DbContext()
    {
        if (string.IsNullOrEmpty(_connectionString))
        {
            throw new InvalidOperationException("The ConnectionString property has not been initialized.");
        }
    }

    public static DbContext GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DbContext();
        }
        return _instance;
    }

    /// <summary>
    /// Executes a non-query command (e.g., INSERT, UPDATE, DELETE).
    /// </summary>
    public int ExecuteNonQuery(DbCommandParams cmdParams)
    {
        return ExecuteCommand(cmdParams, cmd => cmd.ExecuteNonQuery());
    }

    /// <summary>
    /// Executes a scalar query (e.g., SELECT COUNT(*)) and returns the first column of the first row.
    /// </summary>
    public object ExecuteScalar(DbCommandParams cmdParams)
    {
        return ExecuteCommand(cmdParams, cmd => cmd.ExecuteScalar());
    }

    /// <summary>
    /// Executes a query and returns the results as a DataTable.
    /// </summary>
    public DataTable ExecuteDataTable(DbCommandParams cmdParams)
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
    private T ExecuteCommand<T>(DbCommandParams cmdParams, Func<SqlCommand, T> action)
    {
        using (var connection = new SqlConnection(_connectionString))
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
    private void LogError(string message, Exception exception)
    {
        // Replace this with a proper logging framework (e.g., Serilog, NLog)
        Debug.WriteLine($"{message}\n{exception}");
    }
}
