using Database;
using Services.DTOs;
using Services.Services;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Helpers;

public static class GetAllEntitiesHelper
{
    public static List<T> DefaultGetAll<T>(this IBasicCRUDService<T> service, GetAllDto? dto = null) where T : class
    {
        try
        {
            var sql = $@"
                SELECT *
                FROM [{service.ViewName}]
                WHERE 1=1";

            SqlQueryBuilder queryBuilder = new(new(sql, CommandType.Text, new()));

            if (dto == null)
                dto = new();

            // Add filters dynamically
            if (dto.Filters != null)
            {
                queryBuilder.ApplyFilters(dto.Filters);
            }

            // Add ordering
            if (dto.OrderBy == null || dto.OrderBy.Count == 0)
            {
                dto.OrderBy = new() { ["Id"] = 1 };
            }

            queryBuilder.ApplyOrderBy(dto.OrderBy);

            // Add pagination
            if (dto.Skip != null && dto.Take != null && dto.Skip >= 0 && dto.Take > 0)
            {
                queryBuilder.ApplyPagination(dto.Take.Value, dto.Skip.Value);
            }

            var records = service.Mapper.MapFromDataTable(service.Context.ExecuteDataTable(queryBuilder.CmdParams));

            return records;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
