using System;
using System.Collections.Generic;
using System.Data;
using Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappers
{
    public class StudentAnswerMapper : BaseMapper<StudentAnswer>
    {
        public override StudentAnswer MapFromDataRow(DataRow row)
        {
            if (row == null) return null;

            // Convert the DataRow into a StudentAnswer object
            return new StudentAnswer
            {
                StudentExam = Convert.ToInt32(row["StudentExam"]),
                AnswerId = Convert.ToInt32(row["AnswerId"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }
    }
}
