using System;
using System.Threading.Tasks;

using R5T.D0063;
using R5T.T0018;
using R5T.T0064;


namespace R5T.D0062.D0063
{
    [ServiceImplementationMarker]
    public class AspNetCoreEnvironmentVariableEnvironmentNameProvider : IEnvironmentNameProvider, IServiceImplementation
    {
        private IDefaultEnvironmentNameProvider DefaultEnvironmentNameProvider { get; }
        private IEnvironmentVariableProvider EnvironmentVariableProvider { get; }


        public AspNetCoreEnvironmentVariableEnvironmentNameProvider(
            IDefaultEnvironmentNameProvider defaultEnvironmentNameProvider,
            IEnvironmentVariableProvider environmentVariableProvider)
        {
            this.DefaultEnvironmentNameProvider = defaultEnvironmentNameProvider;
            this.EnvironmentVariableProvider = environmentVariableProvider;
        }

        public async Task<string> GetEnvironmentName()
        {
            var aspNetCoreEnvironmentEnvironmentVariableName = EnvironmentVariableNames.Environment;

            var wasFound = await this.EnvironmentVariableProvider.GetEnvironmentVariable(aspNetCoreEnvironmentEnvironmentVariableName);

            if(wasFound)
            {
                return wasFound;
            }
            else
            {
                var defaultEnvironmentName = await this.DefaultEnvironmentNameProvider.GetDefaultEnvironmentName();
                return defaultEnvironmentName;
            }
        }
    }
}
