using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamQuestionMapper : BaseMapper<ExamQuestion>
{
    public override ExamQuestion MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        return new(
            ExamId: Convert.ToInt32(row["ExamId"]),
            QuestionId: Convert.ToInt32(row["QuestionId"])
        );
    }
}
