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
                Mark: Convert.ToDouble(row["Mark"]),
                Body: row["Body"] == DBNull.Value ? null : row["Body"].ToString(),
                QuestionType: row["QuestionType"].ToString(),
                SubjectId: Convert.ToInt32(row["SubjectId"])
            );
        }
    }
}