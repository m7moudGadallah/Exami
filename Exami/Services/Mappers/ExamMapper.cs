using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamMapper : BaseMapper<Exam>
{
    public override Exam MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        // Convert the DataRow into an Exam object
        return new Exam(
           Id: row["Id"] == DBNull.Value ? 0 : Convert.ToInt32(row["Id"]),
           Name: row["Name"].ToString(),
           SubjectId: row["SubjectId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["SubjectId"]),
           StartTime: Convert.ToDateTime(row["StartTime"]),
           EndTime: Convert.ToDateTime(row["EndTime"]),
           ExamType: ParseExamType(row["ExamType"].ToString()),
           Instructions: row["Instructions"] == DBNull.Value ? null : row["Instructions"].ToString()
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
