using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using System.Text;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage student answers, including retrieving a list of student answers based on filters.
/// </summary>
public static class StudentAnswerService
{
    /// <summary>
    /// Retrieves a list of student answers based on the provided filters.
    /// </summary>
    /// <param name="dto">A <see cref="GetAllStudentAnswersInputDto"/> object containing key-value pairs of filters to apply.</param>
    /// <returns>A list of <see cref="StudentAnswer"/> objects that match the specified filters.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation or if invalid filters are provided.
    /// </exception>
    public static List<StudentAnswer> GetAllAnswers(GetAllStudentAnswersInputDto dto)
    {
        try
        {
            var sql = new StringBuilder(@"
                SELECT *
                FROM [StudentAnswer]
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

            var stdAnswers = new StudentAnswerMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams with { Sql = sql.ToString() }));

            return stdAnswers;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
