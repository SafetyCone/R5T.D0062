using System;
using System.Threading.Tasks;


namespace R5T.D0062.Chamavia
{
    public interface IEnvironmentNameConfigurationKeyProvider
    {
        Task<string> GetEnvironmentNameConfigurationKey();
    }
}
