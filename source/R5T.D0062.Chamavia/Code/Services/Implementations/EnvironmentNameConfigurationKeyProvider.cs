using System;
using System.Threading.Tasks;

using R5T.T0022;
using R5T.T0064;


namespace R5T.D0062.Chamavia
{
    [ServiceImplementationMarker]
    public class EnvironmentNameConfigurationKeyProvider : IEnvironmentNameConfigurationKeyProvider, IServiceImplementation
    {
        public Task<string> GetEnvironmentNameConfigurationKey()
        {
            var environmentNameConfigurationKey = ConfigurationSectionNames.Instance.GetEnvironmentName();

            return Task.FromResult(environmentNameConfigurationKey);
        }
    }
}
