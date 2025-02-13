using System.Data;
using Entities;

namespace Services.Mappers;

public class SubjectMapper : BaseMapper<Subject>
{
    public override Subject MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        // Convert the DataRow into a Subject object
        return new Subject(
            Id: Convert.ToInt32(row["Id"]),
            Name: row["Name"] == DBNull.Value ? null : row["Name"].ToString(),
            TeacherId: Convert.ToInt32(row["TeacherId"])
        );
    }

}
