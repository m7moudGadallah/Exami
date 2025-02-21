using System.Data;
using Entities;

namespace Services.Mappers;

public class MarkedQuestionMapper : BaseMapper<MarkedQuestion>
{
    private readonly static string[] Columns = ["StudentExamID", "QuestionId"];

    public override MarkedQuestion MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        return new()
        {
            StudentExamID = Convert.ToInt32(row[columnNameMapping["StudentExamID"]]),
            QuestionId = Convert.ToInt32(row[columnNameMapping["QuestionId"]])
        };
    }
}
