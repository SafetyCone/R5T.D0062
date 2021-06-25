using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;


namespace R5T.D0062.Chamavia
{
    public class EnvironmentNameProvider : IEnvironmentNameProvider
    {
        private IConfiguration Configuration { get; }
        private IDefaultEnvironmentNameProvider DefaultEnvironmentNameProvider { get; }
        private IEnvironmentNameConfigurationKeyProvider EnvironmentNameConfigurationKeyProvider { get; }


        public EnvironmentNameProvider(
            IConfiguration configuration,
            IDefaultEnvironmentNameProvider defaultEnvironmentNameProvider,
            IEnvironmentNameConfigurationKeyProvider environmentNameConfigurationKeyProvider)
        {
            this.Configuration = configuration;
            this.DefaultEnvironmentNameProvider = defaultEnvironmentNameProvider;
            this.EnvironmentNameConfigurationKeyProvider = environmentNameConfigurationKeyProvider;
        }

        public async Task<string> GetEnvironmentName()
        {
            var environmentNameConfigurationKey = await this.EnvironmentNameConfigurationKeyProvider.GetEnvironmentNameConfigurationKey();

            var environmentNameWasFound = this.Configuration.GetValueOkIfNotExists(environmentNameConfigurationKey);
            if(environmentNameWasFound)
            {
                return environmentNameWasFound;
            }
            else
            {
                var defaultEnvironmentName = await this.DefaultEnvironmentNameProvider.GetDefaultEnvironmentName();
                return defaultEnvironmentName;
            }
        }
    }
}
