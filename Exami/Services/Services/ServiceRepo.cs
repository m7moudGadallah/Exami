namespace Services.Services;

public static class ServicesRepo
{
    private static Dictionary<Type, Service> _services = new();

    public static T GetService<T>() where T : Service, new()
    {
        Type serviceType = typeof(T);

        if (!_services.ContainsKey(serviceType) || _services[serviceType] == null)
        {
            _services[serviceType] = new T();
        }

        return (T)_services[serviceType];
    }
}
