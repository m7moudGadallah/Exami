using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamQuestionMapper : BaseMapper<ExamQuestion>
{
    private readonly static string[] Columns = ["ExamId", "QuestionId"];

    public override ExamQuestion MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);
        {
            if (row == null) return null;

            return new()
            {
                ExamId = Convert.ToInt32(row[columnNameMapping["ExamId"]]),
                QuestionId = Convert.ToInt32(row[columnNameMapping["QuestionId"]])
            };
        }
    }
}
