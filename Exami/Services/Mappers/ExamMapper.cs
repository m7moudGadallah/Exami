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
            Name: row["Name"] == DBNull.Value ? null : row["Name"].ToString(),
            SubjectId: row["SubjectId"] == DBNull.Value ? 0 : Convert.ToInt32(row["SubjectId"]),
            StartTime: row["StartTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["StartTime"]),
            EndTime: row["EndTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["EndTime"]),
            ExamType: row["ExamType"] == DBNull.Value ? null : row["ExamType"].ToString(),
            Instructions: row["Instructions"] == DBNull.Value ? null : row["Instructions"].ToString()
        );
    }

}
