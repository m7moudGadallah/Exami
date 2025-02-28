using Entities;
using Services.Mappers;
using System.Data;

public class QuestionMapper : BaseMapper<Question>
{
    private readonly static string[] Columns = ["Id", "Marks", "Body", "QuestionType", "SubjectId"];

    public override Question MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;
        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        var answer = TryMap<AnswerMapper, Answer>(row, new() { ["Id"] = "AnswerId", ["QuestionId"] = "QuestionId" });

        List<Answer> answers = new List<Answer>();

        if (row.Table.Columns.Contains("AnswerId") && row["AnswerId"] != DBNull.Value)
        {
            answers.Add(new AnswerMapper().MapFromDataRow(row, new() { ["Id"] = "AnswerId", ["QuestionId"] = "QuestionId" }));
        }

        return new Question
        {
            Id = Convert.ToInt32(row[columnNameMapping["Id"]]),
            Marks = Convert.ToDouble(row[columnNameMapping["Marks"]]),
            Body = row[columnNameMapping["Body"]].ToString(),
            QuestionType = ParseQuestionType(row[columnNameMapping["QuestionType"]].ToString()),
            SubjectId = row[columnNameMapping["SubjectId"]] == DBNull.Value ? null : Convert.ToInt32(row[columnNameMapping["SubjectId"]]),
            Answers = answer != null ? new List<Answer> { answer } : new List<Answer>()
        };
    }

    private QuestionType ParseQuestionType(string questionType)
    {
        return questionType switch
        {
            "TrueOrFalse" => QuestionType.TrueOrFalse,
            "ChooseOne" => QuestionType.ChooseOne,
            "ChooseAll" => QuestionType.ChooseAll,
            _ => throw new ArgumentException($"Invalid exam type: {questionType}")
        };
    }
}
