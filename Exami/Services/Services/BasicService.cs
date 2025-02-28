using Database;

namespace Services.Services;

public class BasicService : IBasicService
{
    public BasicService()
    {
        Context = DbContext.GetInstance();
    }

    public DbContext Context { get; }
}
