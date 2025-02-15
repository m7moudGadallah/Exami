using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;
using System.Text;

namespace Services.Services;

/// <summary>
/// Provides methods to manage exams, including retrieving exam details by ID.
/// </summary>
public class ExamService
{
    /// <summary>
    /// Retrieves a list of exams based on the provided filters.
    /// </summary>
    /// <param name="dto">A <see cref="GetAllExamsInputDto"/> object containing key-value pairs of filters to apply.</param>
    /// <returns>A list of <see cref="Exam"/> objects that match the specified filters.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// </exception>
    public static List<Exam> GetAllExams(GetAllExamsInputDto dto)
    {
        try
        {
            var sql = new StringBuilder(@"
                SELECT *
                FROM [Exam]
                WHERE 1=1");


            DBCommandParams cmdParams = new(sql.ToString(), CommandType.Text, new() { });

            // Add filters dynamically
            foreach (var filter in dto.Filters)
            {
                string columnName = filter.Key;
                object value = filter.Value;

                if (value != null)
                {
                    sql.Append($" AND {columnName} = @{columnName}");
                    cmdParams.Parameters.Add($"@{columnName}", value);
                }
            }

            var exams = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams with { Sql = sql.ToString() }));

            return exams;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

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
