using System;
using System.Threading.Tasks;


namespace R5T.D0062
{
    /// <summary>
    /// Allows specifying a default environment name if none is available.
    /// </summary>
    public interface IDefaultEnvironmentNameProvider
    {
        Task<string> GetDefaultEnvironmentName();
    }
}
