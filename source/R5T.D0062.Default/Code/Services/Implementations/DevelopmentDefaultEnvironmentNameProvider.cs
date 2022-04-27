using System;
using System.Threading.Tasks;

using R5T.T0019;
using R5T.T0064;


namespace R5T.D0062
{
    /// <summary>
    /// Just return <see cref="EnvironmentNames.Development"/> as the default environment name.
    /// </summary>
    [ServiceImplementationMarker]
    public class DevelopmentDefaultEnvironmentNameProvider : IDefaultEnvironmentNameProvider, IServiceImplementation
    {
        public Task<string> GetDefaultEnvironmentName()
        {
            return Task.FromResult(EnvironmentNames.Development);
        }
    }
}
