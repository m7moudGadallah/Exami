using Database;
using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public class StudentAnswerService : BasicCRUDService<StudentAnswer>, IGetAllEntitiesService<StudentAnswer>, ICreateEntityService<StudentAnswer>
{
    public StudentAnswerService() : base("StudentAnswer", new StudentAnswerMapper()) { }

    public List<StudentAnswer> GetAll(GetAllDto? dto = null)
    {
        if (dto == null)
            dto = new();

        // Add ordering
        if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
        {
            dto.OrderBy = new() { ["StudentExamId"] = 1, ["AnswerId"] = 1 };
        }

        return this.DefaultGetAll(dto);
    }


    public StudentAnswer Create(StudentAnswer dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (StudentExamId, AnswerId, CreatedAt)
                OUTPUT INSERTED.*
                VALUES (@StudentExamId, @AnswerId, GETDATE());";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@StudentExamId"] = dto.StudentExamId,
                ["@AnswerId"] = dto.AnswerId
            });

            var stdAnswer = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return stdAnswer;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public bool Delete(int studentExamId, int answerId)
    {
        try
        {
            var @sql = $@"
                DELETE [{TableName}]
                WHERE StudentExamId = @StudentExamId
                    AND AnswerId = @AnswerId";


            DbCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@StudentExamId"] = studentExamId, ["@AnswerId"] = answerId });

            int rowsAffected = Context.ExecuteNonQuery(cmdParams);

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
