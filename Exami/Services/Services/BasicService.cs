using Database;

namespace Services.Services;

public abstract class BasicService : IBasicService
{
    public BasicService()
    {
        Context = DbContext.GetInstance();
    }

    public DbContext Context { get; }
}
