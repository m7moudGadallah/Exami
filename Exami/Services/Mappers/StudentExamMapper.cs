using System.Data;
using Entities;

namespace Services.Mappers;

public class StudentExamMapper : BaseMapper<StudentExam>
{
    private readonly static string[] Columns = ["Id", "ExamId", "StudentId", "SubmissionTime", "CreatedAt", "UpdatedAt"];

    public override StudentExam MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        // Convert the DataRow into a StudentExam object
        return new()
        {
            Id = Convert.ToInt32(row[columnNameMapping["Id"]]),
            ExamId = Convert.ToInt32(row[columnNameMapping["ExamId"]]),
            StudentId = Convert.ToInt32(row[columnNameMapping["StudentId"]]),
            SubmissionTime = row[columnNameMapping["SubmissionTime"]] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row[columnNameMapping["SubmissionTime"]]),
            CreatedAt = Convert.ToDateTime(row[columnNameMapping["CreatedAt"]]),
            UpdatedAt = Convert.ToDateTime(row[columnNameMapping["UpdatedAt"]]),
            Student = TryMap<UserMapper, User>(row, new() { ["Id"] = "StudentId" }),
            Exam = TryMap<ExamMapper, Exam>(row, new() { ["Id"] = "ExamId" })
        };
    }

}
