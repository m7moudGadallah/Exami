using System.Text;

namespace Database;

/// <summary>
/// A utility class for dynamically building SQL queries with filters, ordering, and pagination.
/// </summary>
/// <remarks>
/// This class allows you to construct SQL queries step-by-step by applying filters, ordering, and pagination.
/// It maintains a <see cref="DbCommandParams"/> object that contains the SQL query string and parameters.
/// </remarks>
public class SqlQueryBuilder
{
    public SqlQueryBuilder(DbCommandParams cmdParams)
    {
        this._sql = new StringBuilder(cmdParams.Sql);
        this._cmdParams = cmdParams;
    }

    private StringBuilder _sql;
    private DbCommandParams _cmdParams;

    /// <summary>
    /// Gets the current <see cref="DbCommandParams"/> object, including the updated SQL query string and parameters.
    /// </summary>
    /// <returns>A <see cref="DbCommandParams"/> object containing the final SQL query and parameters.</returns>
    public DbCommandParams CmdParams { get => _cmdParams with { Sql = _sql.ToString() }; }

    /// <summary>
    /// Applies filters to the SQL query based on the provided key-value pairs.
    /// </summary>
    /// <param name="filters">A dictionary where keys are column names and values are filter values.</param>
    /// <returns>The current <see cref="SqlQueryBuilder"/> instance for method chaining.</returns>
    /// <remarks>
    /// Filters are applied using the format: <c>AND [column] = @parameter</c>.
    /// Null or empty filter values are ignored.
    /// </remarks>
    public SqlQueryBuilder ApplyFilters(Dictionary<string, object> filters)
    {
        foreach (var filter in filters)
        {
            string columnName = filter.Key;
            object value = filter.Value;

            if (value != null)
            {
                _sql.Append($" AND {columnName} = @{columnName}");
                _cmdParams.Parameters.Add($"@{columnName}", value);
            }
        }
        return this;
    }

    /// <summary>
    /// Applies ordering to the SQL query based on the provided column-direction pairs.
    /// </summary>
    /// <param name="orderBy">A dictionary where keys are column names and values are direction indicators (1 for ASC, -1 for DESC).</param>
    /// <returns>The current <see cref="SqlQueryBuilder"/> instance for method chaining.</returns>
    /// <remarks>
    /// Ordering is applied using the format: <c>ORDER BY [column] ASC|DESC</c>.
    /// Columns with a direction value of 0 are ignored.
    /// If no valid columns are provided, the query will not include an ORDER BY clause.
    /// </remarks>
    public SqlQueryBuilder ApplyOrderBy(Dictionary<string, int> orderBy)
    {
        _sql.Append(" ORDER BY ");
        bool first = true;

        foreach (var order in orderBy)
        {
            string columnName = order.Key;
            int direction = order.Value;

            if (direction == 0) continue; // Ignore columns with direction 0

            if (!first)
            {
                _sql.Append(", ");
            }

            _sql.Append($"{columnName} {(direction > 0 ? "ASC" : "DESC")}");
            first = false;
        }

        return this;
    }


    /// <summary>
    /// Applies pagination to the SQL query based on the provided take and skip values.
    /// </summary>
    /// <param name="take">The number of rows to fetch (must be greater than 0).</param>
    /// <param name="skip">The number of rows to skip (must be greater than or equal to 0).</param>
    /// <returns>The current <see cref="SqlQueryBuilder"/> instance for method chaining.</returns>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Thrown if <paramref name="take"/> is less than or equal to 0, or if <paramref name="skip"/> is negative.
    /// </exception>
    /// <remarks>
    /// Pagination is applied using the SQL Server syntax: <c>OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY</c>.
    /// </remarks>
    public SqlQueryBuilder ApplyPagination(int take, int skip)
    {
        _sql.Append(" OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY");
        _cmdParams.Parameters.Add("@Skip", skip);
        _cmdParams.Parameters.Add("@Take", take);
        return this;
    }
}
