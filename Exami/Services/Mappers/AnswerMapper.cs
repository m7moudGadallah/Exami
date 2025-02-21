using System.Data;
using Entities;

namespace Services.Mappers;

public class AnswerMapper : BaseMapper<Answer>
{
    private readonly static string[] Columns = ["Id", "QuestionId", "AnswerText", "IsCorrect"];

    public override Answer MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        return new Answer()
        {
            Id = Convert.ToInt32(row[columnNameMapping["Id"]]),
            QuestionId = row[columnNameMapping["QuestionId"]] == DBNull.Value ? null : Convert.ToInt32(row[columnNameMapping["QuestionId"]]),
            AnswerText = row[columnNameMapping["AnswerText"]].ToString(),
            IsCorrect = Convert.ToBoolean(row[columnNameMapping["IsCorrect"]])
        };
    }
}
