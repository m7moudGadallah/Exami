using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage exams, including retrieving exam details by ID.
/// </summary>
public class ExamService
{
    /// <summary>
    /// Retrieves an exam by its unique identifier.
    /// </summary>
    /// <param name="dto">A <see cref="GetExamInputDto"/> object containing the ID of the exam to retrieve.</param>
    /// <returns>A <see cref="Exam"/> object if an exam with the specified ID exists; otherwise, <see langword="null"/>.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// </exception>
    public static Exam GetExam(GetExamInputDto dto)
    {
        try
        {
            var sql = @"
            SELECT *
            FROM [Exam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = dto.Id });

            var exams = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0) return null;

            return exams[0];
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
