using System.Data;
using Entities;

namespace Services.Mappers;

public class StudentExamMapper : BaseMapper<StudentExam>
{
    public override StudentExam MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        // Convert the DataRow into a StudentExam object
        return new StudentExam(
            Id: Convert.ToInt32(row["Id"]),
            ExamId: Convert.ToInt32(row["ExamId"]),
            StudentId: Convert.ToInt32(row["StudentId"]),
            SubmissionTime: row["SubmissionTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["SubmissionTime"]),
            CreatedAt: Convert.ToDateTime(row["CreatedAt"]),
            UpdatedAt: Convert.ToDateTime(row["UpdatedAt"])
        );
    }

}
