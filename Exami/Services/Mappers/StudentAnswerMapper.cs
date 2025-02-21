using System.Data;
using Entities;

namespace Services.Mappers;

public class StudentAnswerMapper : BaseMapper<StudentAnswer>
{
    private readonly static string[] Columns = ["StudentExamID", "AnswerId", "CreatedAt"];

    public override StudentAnswer MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        // Convert the DataRow into a StudentAnswer object
        return new()
        {
            StudentExamId = Convert.ToInt32(row[columnNameMapping["StudentExamId"]]),
            AnswerId = Convert.ToInt32(row[columnNameMapping["AnswerId"]]),
            CreatedAt = (row[columnNameMapping["CreatedAt"]] == DBNull.Value) ? null : Convert.ToDateTime(row[columnNameMapping["CreatedAt"]])
        };
    }
}
