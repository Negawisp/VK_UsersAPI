using Microsoft.Extensions.Configuration;

namespace Domain.Utility
{
    public static class ConfigHelper
    {
        private const string _configFileName = "appconfig.json";

        public const string UserGroupCodes_EntryName = "UserGroupCodes";
        public const string UserStateCodes_EntryName = "UserStateCodes";

        private static IConfigurationRoot? _config;
        public static IConfigurationRoot Config
        {
            get
            {
                _config ??= BuildConfig();
                return _config;
            }
        }

        private static IConfigurationRoot BuildConfig()
        {
            string baseDir = AppContext.BaseDirectory;
            if (baseDir == null || baseDir == "")
            {
                throw new DirectoryNotFoundException("Unable to find the application's base directory. Please, contact the developer for further info at kosinoff23@gmail.com.");
            }

            string parentDirectory = Directory.GetParent(baseDir).FullName;
            string configPath = Path.Combine(parentDirectory, "appconfig.json");

            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(parentDirectory)
                .AddJsonFile(configPath);

            return configBuilder.Build();
        }
    }
}
