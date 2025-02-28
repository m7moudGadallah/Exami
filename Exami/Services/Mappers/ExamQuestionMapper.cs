using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamQuestionMapper : BaseMapper<ExamQuestion>
{
    private readonly static string[] Columns = ["ExamId", "QuestionId"];

    // Flat mapping from DataRow
    public override ExamQuestion MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;
        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        return new ExamQuestion
        {
            ExamId = Convert.ToInt32(row[columnNameMapping["ExamId"]]),
            QuestionId = Convert.ToInt32(row[columnNameMapping["QuestionId"]]),
            Question = TryMap<QuestionMapper, Question>(row)
        };
    }

    // Grouping happens here from flat-mapped data
    public override List<ExamQuestion> MapFromDataTable(DataTable table)
    {
        if (table == null || table.Rows.Count == 0) return new List<ExamQuestion>();

        var flatExamQuestions = table.AsEnumerable()
            .Select(row => MapFromDataRow(row))
            .ToList();

        // Group by ExamId and QuestionId, then merge answers
        var groupedExamQuestions = flatExamQuestions
            .GroupBy(eq => new { eq.ExamId, eq.QuestionId })
            .Select(group =>
            {
                var first = group.First();
                var allAnswers = group
                    .SelectMany(eq => eq.Question.Answers ?? new List<Answer>())
                    .ToList();

                first.Question.Answers = allAnswers;
                return first;
            })
            .ToList();

        return groupedExamQuestions;
    }
}
