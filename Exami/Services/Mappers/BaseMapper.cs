using System.Data;

namespace Services.Mappers;

public abstract class BaseMapper<T> where T : class
{
    protected Dictionary<string, string> InitializeColumnNameMapping(string[] columns, Dictionary<string, string> inputMapping)
    {
        var result = inputMapping ?? new Dictionary<string, string>();

        foreach (var column in columns)
        {
            if (!result.ContainsKey(column))
            {
                result[column] = column; // Use the default column name if not specified
            }
        }

        return result;
    }

    public abstract T MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null);

    public virtual List<T> MapFromDataTable(DataTable table)
    {
        var result = new List<T>();
        foreach (DataRow row in table.Rows)
        {
            result.Add(MapFromDataRow(row));
        }
        return result;
    }
}
