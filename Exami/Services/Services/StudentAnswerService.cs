using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using System.Text;
using Utilities.Exceptoins;

namespace Services.Services;

public class StudentAnswerService : CRUDService<StudentAnswer>
{
    public StudentAnswerService() : base("StudentAnswer", new StudentAnswerMapper()) { }

    public override List<StudentAnswer> GetAll(GetAllDto? dto = null)
    {
        if (dto == null)
            dto = new();

        if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
        {
            dto.OrderBy = new() { ["StudentExamId"] = 1, ["AnswerId"] = 1 };
        }

        return base.GetAll(dto);
    }


    public override StudentAnswer Create(StudentAnswer dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (StudentExamId, AnswerId, CreatedAt)
                OUTPUT INSERTED.*
                VALUES (@StudentExamId, @AnswerId, GETDATE());";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@StudentExamId"] = dto.StudentExamId,
                ["@AnswerId"] = dto.AnswerId
            });

            var stdAnswer = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return stdAnswer;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override StudentAnswer Update(StudentAnswer dto)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(int id)
    {
        throw new NotSupportedException();
    }

    public bool Delete(int studentExamId, int answerId)
    {
        try
        {
            var @sql = $@"
                DELETE [{_tableName}]
                WHERE StudentExamId = @StudentExamId
                    AND AnswerId = @AnswerId";


            DbCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@StudentExamId"] = studentExamId, ["@AnswerId"] = answerId });

            int rowsAffected = _dbContext.ExecuteNonQuery(cmdParams);

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
