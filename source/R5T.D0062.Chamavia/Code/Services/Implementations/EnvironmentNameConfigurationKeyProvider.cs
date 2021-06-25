using System;
using System.Threading.Tasks;

using R5T.T0022;


namespace R5T.D0062.Chamavia
{
    public class EnvironmentNameConfigurationKeyProvider : IEnvironmentNameConfigurationKeyProvider
    {
        public Task<string> GetEnvironmentNameConfigurationKey()
        {
            var environmentNameConfigurationKey = ConfigurationSectionNames.Instance.GetEnvironmentName();

            return Task.FromResult(environmentNameConfigurationKey);
        }
    }
}
