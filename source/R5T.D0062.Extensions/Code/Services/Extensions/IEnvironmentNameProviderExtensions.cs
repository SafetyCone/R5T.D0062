using System;
using System.Threading.Tasks;

using R5T.T0019;


namespace R5T.D0062
{
    /// <summary>
    /// Note, many of these extensions exist in Microsoft.Extensions.Hosting.Abstractions, Microsoft.Extensions.Hosting.HostEnvironmentEnvExtensions.
    /// However, they are not asynchronous, and do not work on the <see cref="IEnvironmentNameProvider"/> service! (They are not *just right* for our purposes.)
    /// </summary>
    public static class IEnvironmentNameProviderExtensions
    {
        public static async Task<bool> IsEnvironment(this IEnvironmentNameProvider environmentNameProvider, string environmentName)
        {
            var providedEnvironmentName = await environmentNameProvider.GetEnvironmentName();

            var output = providedEnvironmentName == environmentName;
            return output;
        }

        public static Task<bool> IsDevelopment(this IEnvironmentNameProvider environmentNameProvider)
        {
            return environmentNameProvider.IsEnvironment(EnvironmentNames.Development);
        }

        public static Task<bool> IsProduction(this IEnvironmentNameProvider environmentNameProvider)
        {
            return environmentNameProvider.IsEnvironment(EnvironmentNames.Production);
        }

        public static Task<bool> IsStaging(this IEnvironmentNameProvider environmentNameProvider)
        {
            return environmentNameProvider.IsEnvironment(EnvironmentNames.Statging);
        }
    }
}
