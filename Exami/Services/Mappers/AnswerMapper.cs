using System.Data;
using Entities;

namespace Services.Mappers;

public class AnswerMapper : BaseMapper<Answer>
{
    public override Answer MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        return new Answer(
            Id: Convert.ToInt32(row["Id"]),
            QuestionId: row["QuestionId"] == DBNull.Value ? null : Convert.ToInt32(row["QuestionId"]),
            AnswerText: row["AnswerText"].ToString(),
            IsCorrect: Convert.ToBoolean(row["IsCorrect"])
       );
    }
}
