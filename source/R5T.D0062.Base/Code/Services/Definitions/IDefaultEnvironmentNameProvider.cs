using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0062
{
    /// <summary>
    /// Allows specifying a default environment name if none is available.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDefaultEnvironmentNameProvider : IServiceDefinition
    {
        Task<string> GetDefaultEnvironmentName();
    }
}
