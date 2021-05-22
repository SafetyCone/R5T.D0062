using System;
using System.Threading.Tasks;

namespace R5T.D0062
{
    public class ConstructorBasedDefaultEnvironmentNameProvider : IDefaultEnvironmentNameProvider
    {
        private string DefaultEnvironmentName { get; }


        public ConstructorBasedDefaultEnvironmentNameProvider(
            string defaultEnvironmentName)
        {
            this.DefaultEnvironmentName = defaultEnvironmentName;
        }

        public Task<string> GetDefaultEnvironmentName()
        {
            return Task.FromResult(this.DefaultEnvironmentName);
        }
    }
}
