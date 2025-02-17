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


            return new Question(
                Id: Convert.ToInt32(row[columnNameMapping["Id"]]),
                Marks: Convert.ToDouble(row[columnNameMapping["Marks"]]),
                Body: row[columnNameMapping["Body"]].ToString(),
                QuestionType: ParseQuetionType(row[columnNameMapping["QuestionType"]].ToString()),
                SubjectId: row[columnNameMapping["SubjectId"]] == DBNull.Value ? null : Convert.ToInt32(row[columnNameMapping["SubjectId"]])
            );
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
