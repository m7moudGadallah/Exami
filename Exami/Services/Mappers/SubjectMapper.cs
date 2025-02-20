using System.Data;
using Entities;

namespace Services.Mappers;

public class SubjectMapper : BaseMapper<Subject>
{
    private readonly static string[] Columns = ["Id", "Name", "TeacherId"];

    public override Subject MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        User teacher = null;

        if (row.Table.Columns.Contains("FirstName"))
        {
            teacher = new UserMapper().MapFromDataRow(row, new() { ["Id"] = "TeacherId" });
        }

        return new Subject(
            Id: Convert.ToInt32(row[columnNameMapping["Id"]]),
            Name: row[columnNameMapping["Name"]].ToString(),
            TeacherId: (row["TeacherId"] == DBNull.Value) ? null : Convert.ToInt32(row[columnNameMapping["TeacherId"]])
        )
        {
            Teacher = teacher
        };
    }

}
