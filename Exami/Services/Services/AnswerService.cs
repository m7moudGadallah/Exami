using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public class AnswerService : BasicCRUDService<Answer>, IGetAllEntitiesService<Answer>, ICreateEntityService<Answer>, IUpdateEntityService<Answer>, IDeleteEntityService<Answer>
{
    public AnswerService() : base("Answer", new AnswerMapper()) { }

    public List<Answer> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);

    public Answer Create(Answer dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (QuestionId, AnswerText, IsCorrect)
                OUTPUT INSERTED.*
                VALUES (@QuestionId, @AnswerText, @IsCorrect);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@QuestionId"] = dto?.QuestionId == null ? DBNull.Value : dto.QuestionId,
                ["@AnswerText"] = dto.AnswerText,
                ["@IsCorrect"] = dto.IsCorrect
            });

            var user = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return user;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public Answer Update(Answer dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{TableName}]
            SET QuestionId = @QuestionId,
                AnswerText = @AnswerText,
                IsCorrect = @IsCorrect,
            OUTPUT INSERTED.*
            WHERE Id = @Id;";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@QuestionId"] = dto?.QuestionId == null ? DBNull.Value : dto.QuestionId,
                ["@AnswerText"] = dto.AnswerText,
                ["@IsCorrect"] = dto.IsCorrect
            });

            var users = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams));

            if (users.Count == 0)
            {
                throw new AppException($"Cant find answer with [Id = {dto.Id}]", ExceptionStatus.Error);
            }

            return users[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public bool Delete(int id) => this.DefaultDelete(id);

}
