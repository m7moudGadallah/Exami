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
public static class ExamService
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
            var sql = @"
                SELECT *
                FROM [ExamFullView]
                WHERE 1=1";

            SqlQueryBuilder queryBuilder = new(new(sql, CommandType.Text, new() { }));

            // Add filters dynamically
            if (dto?.Filters != null)
            {
                queryBuilder.ApplyFilters(dto.Filters);
            }

            // Add ordering
            if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
            {
                dto.OrderBy = new() { ["Id"] = 1 };
            }

            queryBuilder.ApplyOrderBy(dto.OrderBy);

            // Add pagination
            if (dto?.Skip != null && dto?.Take != null && dto.Skip >= 0 && dto.Take > 0)
            {
                queryBuilder.ApplyPagination(dto.Take.Value, dto.Skip.Value);
            }

            var exams = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(queryBuilder.CmdParams));

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
