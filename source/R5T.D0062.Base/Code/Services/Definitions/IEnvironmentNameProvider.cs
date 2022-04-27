using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0062
{
    [ServiceDefinitionMarker]
    public interface IEnvironmentNameProvider : IServiceDefinition
    {
        Task<string> GetEnvironmentName();
    }
}
