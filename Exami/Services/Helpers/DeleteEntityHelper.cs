using Database;
using Services.Services;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Helpers;

public static class DeleteEntityHelper
{
    public static bool DefaultDelete<T>(this IBasicCRUDService<T> service, int id) where T : class
    {
        try
        {
            var sql = $@"
                DELETE FROM [{service.TableName}]
                WHERE Id = @Id";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = id });

            int rowsAffected = service.Context.ExecuteNonQuery(cmdParams);
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
