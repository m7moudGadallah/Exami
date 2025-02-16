using Microsoft.Extensions.Configuration;

namespace Utilities.Config;
public static class AppConfig
{
    private static string _configFileName = "appsettings.json";
    private static IConfigurationRoot _configObj = new ConfigurationBuilder().AddJsonFile(_configFileName).Build();

    public static string ConnectionString
    {
        get => _configObj.GetSection("ConnectionString").Value;
    }
}
