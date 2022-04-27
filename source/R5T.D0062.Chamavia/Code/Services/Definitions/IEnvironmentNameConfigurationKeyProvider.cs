using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0062.Chamavia
{
    [ServiceDefinitionMarker]
    public interface IEnvironmentNameConfigurationKeyProvider : IServiceDefinition
    {
        Task<string> GetEnvironmentNameConfigurationKey();
    }
}
