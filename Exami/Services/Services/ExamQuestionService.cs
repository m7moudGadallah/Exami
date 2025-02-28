using Database;
using System.Data;
using Entities;
using Services.Mappers;
using Utilities.Exceptoins;
using Services.DTOs;
using Services.Helpers;

namespace Services.Services;

public class ExamQuestionService : BasicCRUDService<ExamQuestion>, IGetAllEntitiesService<ExamQuestion>, ICreateEntityService<ExamQuestion>, IDeleteEntityService<ExamQuestion>
{
    public ExamQuestionService() : base("ExamQuestion", "ExamQuestionFullView", new ExamQuestionMapper()) { }

    public List<ExamQuestion> GetAll(GetAllDto? dto = null)
    {
        if (dto == null)
            dto = new();

        if (dto?.OrderBy == null)
        {
            dto.OrderBy = new()
            {
                ["ExamId"] = 1,
                ["QuestionId"] = 1
            };
        }

        return this.DefaultGetAll(dto);
    }

    public ExamQuestion Create(ExamQuestion dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (ExamId, QuestionId)
                OUTPUT INSERTED.*
                VALUES (@ExamId, @QuestionId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@ExamId"] = dto.ExamId,
                ["@QuestionId"] = dto.QuestionId
            });

            var examQuestion = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return examQuestion;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public bool Delete(int id) => this.DefaultDelete(id);
}
