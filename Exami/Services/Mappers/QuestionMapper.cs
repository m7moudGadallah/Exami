using System;
using System.Data;
using Entities;

namespace Services.Mappers
{
    public class QuestionMapper : BaseMapper<Question>
    {
        private readonly static string[] Columns = ["Id", "Marks", "Body", "QuestionType", "SubjectId"];

        public override Question MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
        {
            if (row == null) return null;

            if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();
            InitializeColumnNameMapping(Columns, columnNameMapping);

            List<Answer> answers = new List<Answer>();

            if (row.Table.Columns.Contains("AnswerId") && row["AnswerId"] != DBNull.Value)
            {
                answers.Add(new AnswerMapper().MapFromDataRow(row, new() { ["Id"] = "AnswerId", ["QuestionId"] = "Id" }));
            }

            return new()
            {
                Id = Convert.ToInt32(row[columnNameMapping["Id"]]),
                Marks = Convert.ToDouble(row[columnNameMapping["Marks"]]),
                Body = row[columnNameMapping["Body"]].ToString(),
                QuestionType = ParseQuetionType(row[columnNameMapping["QuestionType"]].ToString()),
                SubjectId = row[columnNameMapping["SubjectId"]] == DBNull.Value ? null : Convert.ToInt32(row[columnNameMapping["SubjectId"]]),
                Answers = answers
            };
        }

        public override List<Question> MapFromDataTable(DataTable table)
        {
            var questions = base.MapFromDataTable(table);

            var compactQuestions = questions.GroupBy(q => q.Id).Select(group =>
            {
                var question = group.First();
                question.Answers = group.SelectMany(q => q.Answers).ToList();
                return question;
            }).ToList();

            return compactQuestions;
        }

        private QuestionType ParseQuetionType(string questionType)
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
}
