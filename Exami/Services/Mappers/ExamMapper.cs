using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamMapper : BaseMapper<Exam>
{
    private readonly static string[] Columns = ["Id", "Name", "SubjectId", "StartTime", "EndTime", "ExamType", "Instructions"];

    public override Exam MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        // Convert the DataRow into an Exam object
        return new Exam(
           Id: row[columnNameMapping["Id"]] == DBNull.Value ? 0 : Convert.ToInt32(row[columnNameMapping["Id"]]),
           Name: row[columnNameMapping["Name"]].ToString(),
           SubjectId: row[columnNameMapping["SubjectId"]] == DBNull.Value ? (int?)null : Convert.ToInt32(row[columnNameMapping["SubjectId"]]),
           StartTime: Convert.ToDateTime(row[columnNameMapping["StartTime"]]),
           EndTime: Convert.ToDateTime(row[columnNameMapping["EndTime"]]),
           ExamType: ParseExamType(row[columnNameMapping["ExamType"]].ToString()),
           Instructions: row[columnNameMapping["Instructions"]] == DBNull.Value ? null : row[columnNameMapping["Instructions"]].ToString()
       );
    }


    private ExamType ParseExamType(string examType)
    {
        return examType switch
        {
            "Practice" => ExamType.Practice,
            "Final" => ExamType.Final,
            _ => throw new ArgumentException($"Invalid exam type: {examType}")
        };
    }
}
