using System;
using Microsoft.Extensions.Configuration;

namespace BuyPlan.Automation.Framework.Config
{
    public class Settings
    {
        private static readonly Lazy<Settings> settings =
            new Lazy<Settings>(() =>
            {
                var configBuilder = new ConfigurationBuilder()
                    .AddJsonFile("appSettings.json");
                IConfigurationRoot configuration = configBuilder.Build();

                var settings = new Settings
                {
                    _appSettings = configuration.Get<AppSettings>()
                };

                return settings;
                
            });

        private AppSettings _appSettings;

        public static AppSettings AppSettings => settings.Value._appSettings;

        private Settings() { }
    }
}