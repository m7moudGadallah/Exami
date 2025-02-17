using Database;
using Entities;
using Microsoft.IdentityModel.Tokens;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using System.Data.Common;
using System.Text;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage student exams, including retrieving, updating, and filtering exam records.
/// </summary>
public static class StudentExamService
{
    /// <summary>
    /// Retrieves a list of student exams based on the provided filters, ordering, and pagination parameters.
    /// </summary>
    /// <param name="dto">A <see cref="GetAllStudentExamsInputDto"/> object containing the following properties:
    ///     <list type="bullet">
    ///         <item>
    ///             <description><paramref name="Filters"/>: A dictionary of key-value pairs representing column names and their corresponding filter values. 
    ///             Filters are applied dynamically to the query using `AND` conditions.</description>
    ///         </item>
    ///         <item>
    ///             <description><paramref name="OrderBy"/>: A dictionary where the key is the column name and the value is the sort direction. 
    ///             A positive value indicates ascending order (`ASC`), a negative value indicates descending order (`DESC`), and a value of `0` ignores the column. 
    ///             If no ordering is specified, the method defaults to sorting by `CreatedAt` in descending order (`DESC`).</description>
    ///         </item>
    ///         <item>
    ///             <description><paramref name="Skip"/>: The number of rows to skip for pagination. Must be greater than or equal to `0`. 
    ///             If not provided or invalid, pagination is ignored.</description>
    ///         </item>
    ///         <item>
    ///             <description><paramref name="Take"/>: The number of rows to retrieve for pagination. Must be greater than `0`. 
    ///             If not provided or invalid, pagination is ignored.</description>
    ///         </item>
    ///     </list>
    /// </param>
    /// <returns>A list of <see cref="StudentExam"/> objects matching the filters, ordered, and paginated as specified.</returns>
    /// <exception cref="AppException">Thrown if an error occurs during database execution, such as invalid SQL syntax or database connectivity issues.</exception>
    /// <remarks>
    /// - The method ensures that the `ORDER BY` clause is always present when using pagination, defaulting to `CreatedAt DESC` if no ordering is provided.
    /// - Filters are applied dynamically, and only non-null values are considered.
    /// - Pagination uses the SQL Server `OFFSET ... FETCH` syntax, requiring valid `Skip` and `Take` values.
    /// </remarks>
    public static List<StudentExam> GetAllStudentExams(GetAllStudentExamsInputDto dto)
    {
        try
        {
            var sql = new StringBuilder(@"
                SELECT *    
                FROM [StudentExamFullView]
                WHERE 1=1");


            DBCommandParams cmdParams = new(sql.ToString(), CommandType.Text, new() { });

            // Add filters dynamically
            if (dto?.Filters != null)
            {
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
            }

            // Add ordering
            if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
            {
                dto.OrderBy = new() { ["CreatedAt"] = -1 };
            }
            sql.Append(" ORDER BY ");
            bool first = true;

            foreach (var order in dto.OrderBy)
            {
                string columnName = order.Key;
                int direction = order.Value;

                if (direction == 0) continue; // Ignore columns with direction 0

                if (!first)
                {
                    sql.Append(", ");
                }

                sql.Append($"{columnName} {(direction > 0 ? "ASC" : "DESC")}");
                first = false;
            }

            // Add pagination
            if (dto?.Skip != null && dto?.Take != null && dto.Skip >= 0 && dto.Take > 0)
            {
                sql.Append(" OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY");
                cmdParams.Parameters.Add("@Skip", dto.Skip.Value);
                cmdParams.Parameters.Add("@Take", dto.Take.Value);
            }

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams with { Sql = sql.ToString() }));

            return exams;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Retrieves a single student exam by its ID.
    /// </summary>
    /// <param name="dto">A <see cref="GetStudentExamInputDto"/> object containing the ID of the exam to retrieve.</param>
    /// <returns>A <see cref="StudentExam"/> object if found; otherwise, <see langword="null"/>.</returns>
    /// <exception cref="AppException">Thrown if an error occurs during database execution.</exception> 
    public static StudentExam? GetStudentExam(GetStudentExamInputDto dto)
    {
        try
        {
            var sql = @"
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = dto.Id });

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0) return null;

            return exams[0];
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Updates an existing student exam record in the database.
    /// </summary>
    /// <param name="exam">A <see cref="StudentExam"/> object containing the updated exam details.</param>
    /// <returns>The updated <see cref="StudentExam"/> object.</returns>
    /// <exception cref="AppException">
    /// Thrown if the exam with the specified ID is not found or if an error occurs during database execution.
    /// </exception>
    public static StudentExam UpdateStudentExam(StudentExam exam)
    {
        try
        {
            var sql = @"
            UPDATE [StudentExam]
            SET ExamId = @ExamId,
                StudentId = @StudentId,
                SubmissionTime = @SubmissionTime,
                UpdatedAt = GETDATE()
            WHERE Id = @Id
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = exam.Id,
                ["@ExamId"] = exam.ExamId,
                ["@StudentId"] = exam.StudentId,
                ["@SubmissionTime"] = (exam.SubmissionTime == null) ? DBNull.Value : exam.SubmissionTime,
            });

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0)
            {
                throw new AppException($"Cant find exam with [Id = {exam.Id}]", ExceptionStatus.Error);
            }

            return exams[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
