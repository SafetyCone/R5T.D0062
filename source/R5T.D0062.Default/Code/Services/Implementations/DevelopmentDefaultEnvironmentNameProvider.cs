using System;
using System.Threading.Tasks;

using R5T.T0019;


namespace R5T.D0062
{
    /// <summary>
    /// Just return <see cref="EnvironmentNames.Development"/> as the default environment name.
    /// </summary>
    public class DevelopmentDefaultEnvironmentNameProvider : IDefaultEnvironmentNameProvider
    {
        public Task<string> GetDefaultEnvironmentName()
        {
            return Task.FromResult(EnvironmentNames.Development);
        }
    }
}
