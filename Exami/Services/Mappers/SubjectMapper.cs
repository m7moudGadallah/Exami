using System.Data;
using Entities;

namespace Services.Mappers;

public class SubjectMapper : BaseMapper<Subject>
{
    public override Subject MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        return new Subject(
            Id: Convert.ToInt32(row["Id"]),
            Name: row["Name"].ToString(),
            TeacherId: (row["TeacherId"] == DBNull.Value) ? null : Convert.ToInt32(row["TeacherId"])
        );
    }

}
