using System;
using System.Data;
using Entities;

namespace Services.Mappers
{
    public class QuestionMapper : BaseMapper<Question>
    {
        public override Question MapFromDataRow(DataRow row)
        {
            if (row == null) return null;


            return new Question(
                Id: Convert.ToInt32(row["Id"]),
                Marks: Convert.ToDouble(row["Marks"]),
                Body: row["Body"].ToString(),
                QuestionType: ParseQuetionType(row["QuestionType"].ToString()),
                SubjectId: row["SubjectId"] == DBNull.Value ? null : Convert.ToInt32(row["SubjectId"])
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
