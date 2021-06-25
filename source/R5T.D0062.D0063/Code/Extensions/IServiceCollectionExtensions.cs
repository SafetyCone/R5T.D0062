using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0063;


namespace R5T.D0062.D0063
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AspNetCoreEnvironmentVariableEnvironmentNameProvider"/> implementation of <see cref="IEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAspNetCoreEnvironmentVariableEnvironmentNameProvider(this IServiceCollection services,
            IServiceAction<IDefaultEnvironmentNameProvider> defaultEnvironmentNameProviderAction,
            IServiceAction<IEnvironmentVariableProvider> environmentVariableProviderAction)
        {
            services
                .AddSingleton<IEnvironmentNameProvider, AspNetCoreEnvironmentVariableEnvironmentNameProvider>()
                .Run(defaultEnvironmentNameProviderAction)
                .Run(environmentVariableProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AspNetCoreEnvironmentVariableEnvironmentNameProvider"/> implementation of <see cref="IEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameProvider> AddAspNetCoreEnvironmentVariableEnvironmentNameProviderAction(this IServiceCollection services,
            IServiceAction<IDefaultEnvironmentNameProvider> defaultEnvironmentNameProviderAction,
            IServiceAction<IEnvironmentVariableProvider> environmentVariableProviderAction)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameProvider>(() => services.AddAspNetCoreEnvironmentVariableEnvironmentNameProvider(
                defaultEnvironmentNameProviderAction,
                environmentVariableProviderAction));

            return serviceAction;
        }
    }
}
