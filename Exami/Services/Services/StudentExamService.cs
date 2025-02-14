using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;

namespace Services.Services;

public class StudentExamService
{
    public static StudentExam? GetStudentExam(GetStudentExamInputDto data)
    {
        var sql = @"
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

        DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = data.Id });

        var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

        if (exams.Count == 0) return null;

        return exams[0];
    }
}
