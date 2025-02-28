using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamStudentPerformanceMapper : BaseMapper<ExamStudentPerformance>
{
    private readonly static string[] Columns =
    [
        "ExamId", "StudentExamId", "ExamName", "StudentName",
        "ExamStartTime", "ExamSubmissionTime", "StudentScore"
    ];

    public override ExamStudentPerformance MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        return new()
        {
            ExamId = Convert.ToInt32(row[columnNameMapping["ExamId"]]),
            StudentExamId = Convert.ToInt32(row[columnNameMapping["StudentExamId"]]),
            ExamName = row[columnNameMapping["ExamName"]] as string ?? string.Empty,
            StudentName = row[columnNameMapping["StudentName"]] as string ?? string.Empty,
            ExamStartTime = Convert.ToDateTime(row[columnNameMapping["ExamStartTime"]]),
            ExamSubmissionTime = row[columnNameMapping["ExamSubmissionTime"]] == DBNull.Value
                ? null
                : Convert.ToDateTime(row[columnNameMapping["ExamSubmissionTime"]]),
            StudentScore = Convert.ToDouble(row[columnNameMapping["StudentScore"]])
        };
    }
}
