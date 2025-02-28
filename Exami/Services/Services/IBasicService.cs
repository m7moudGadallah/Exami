using Database;

namespace Services.Services;

public interface IBasicService
{
    public DbContext Context { get; }
}
