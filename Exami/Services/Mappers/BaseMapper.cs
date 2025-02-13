using System.Data;

namespace Services.Mappers;

public abstract class BaseMapper<T> where T : class
{

    public abstract T MapFromDataRow(DataRow row);

    public List<T> MapFromDataTable(DataTable table)
    {
        var result = new List<T>();
        foreach (DataRow row in table.Rows)
        {
            result.Add(MapFromDataRow(row));
        }
        return result;
    }
}
