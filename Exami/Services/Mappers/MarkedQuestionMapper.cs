using System.Data;
using Entities;

namespace Services.Mappers;

public class MarkedQuestionMapper : BaseMapper<MarkedQuestion>
{
    public override MarkedQuestion MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        return new(
            StudentExamID: Convert.ToInt32(row["StudentExamID"]),
            QuestionId: Convert.ToInt32(row["QuestionId"])
            );
    }
}
