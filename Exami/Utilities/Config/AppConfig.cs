using Microsoft.Extensions.Configuration;

namespace Utilities.Config
{
    public static class AppConfig
    {
        private static readonly IConfigurationRoot configuration;

        static AppConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }

        public static string ConnectionString => configuration.GetConnectionString("DefaultConnection");
    }
}
