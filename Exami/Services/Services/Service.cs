using Database;

namespace Services.Services;

public class Service
{
    protected DbContext _dbContext = DbContext.GetInstance();
}
