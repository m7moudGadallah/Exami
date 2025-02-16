using System.Data;
using Entities;﻿

namespace Services.Mappers;

public class StudentAnswerMapper : BaseMapper<StudentAnswer>
{
    public override StudentAnswer MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        // Convert the DataRow into a StudentAnswer object
        return new StudentAnswer(
            StudentExamId: Convert.ToInt32(row["StudentExamId"]),
            AnswerId: Convert.ToInt32(row["AnswerId"]),
            CreatedAt: (row["CreatedAt"] == DBNull.Value) ? null : Convert.ToDateTime(row["CreatedAt"])
        );
    }
}
