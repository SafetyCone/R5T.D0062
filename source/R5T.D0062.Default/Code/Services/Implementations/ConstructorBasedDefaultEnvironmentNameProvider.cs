using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0062
{
    [ServiceImplementationMarker]
    public class ConstructorBasedDefaultEnvironmentNameProvider : IDefaultEnvironmentNameProvider, IServiceImplementation
    {
        private string DefaultEnvironmentName { get; }


        public ConstructorBasedDefaultEnvironmentNameProvider(
            [NotServiceComponent] string defaultEnvironmentName)
        {
            this.DefaultEnvironmentName = defaultEnvironmentName;
        }

        public Task<string> GetDefaultEnvironmentName()
        {
            return Task.FromResult(this.DefaultEnvironmentName);
        }
    }
}
