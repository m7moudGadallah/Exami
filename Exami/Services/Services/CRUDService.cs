using Database;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public abstract class CRUDService<T> : Service where T : class
{
    protected string _viewName;
    protected string _tableName;
    protected BaseMapper<T> _mapper;

    protected CRUDService(string tableName, string viewName, BaseMapper<T> mapper) : base()
    {
        _tableName = tableName;
        _viewName = viewName;
        _mapper = mapper;
    }
    protected CRUDService(string _tableName, BaseMapper<T> mapper) : this(_tableName, _tableName, mapper) { }

    public virtual List<T> GetAll(GetAllDto? dto = null)
    {
        try
        {
            var sql = $@"
                SELECT *
                FROM [{_viewName}]
                WHERE 1=1";

            SqlQueryBuilder queryBuilder = new(new(sql, CommandType.Text, new()));

            if (dto == null)
                dto = new();

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

            var records = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(queryBuilder.CmdParams));

            return records;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public abstract T Create(T dto);
    public abstract T Update(T dto);

    public virtual bool Delete(int id)
    {
        try
        {
            var @sql = $@"
                DELETE [{_tableName}]
                WHERE Id = @Id";


            DbCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = id });

            int rowsAffected = _dbContext.ExecuteNonQuery(cmdParams);

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
