using System;
using System.Threading.Tasks;


namespace R5T.D0062
{
    public interface IEnvironmentNameProvider
    {
        Task<string> GetEnvironmentName();
    }
}
