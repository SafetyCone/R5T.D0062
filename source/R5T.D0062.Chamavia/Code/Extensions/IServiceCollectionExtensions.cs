using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0062.Chamavia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EnvironmentNameConfigurationKeyProvider"/> implementation of <see cref="IEnvironmentNameConfigurationKeyProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentNameConfigurationKeyProvider(this IServiceCollection services)
        {
            services.AddSingleton<IEnvironmentNameConfigurationKeyProvider, EnvironmentNameConfigurationKeyProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameConfigurationKeyProvider"/> implementation of <see cref="IEnvironmentNameConfigurationKeyProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameConfigurationKeyProvider> AddEnvironmentNameConfigurationKeyProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameConfigurationKeyProvider>(() => services.AddEnvironmentNameConfigurationKeyProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameProvider"/> implementation of <see cref="IEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentNameProvider(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IDefaultEnvironmentNameProvider> defaultEnvironmentNameProviderAction,
            IServiceAction<IEnvironmentNameConfigurationKeyProvider> environmentNameConfigurationKeyProviderAction)
        {
            services.AddSingleton<IEnvironmentNameProvider, EnvironmentNameProvider>()
                .Run(configurationAction)
                .Run(defaultEnvironmentNameProviderAction)
                .Run(environmentNameConfigurationKeyProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameProvider"/> implementation of <see cref="IEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IEnvironmentNameProvider> AddEnvironmentNameProviderAction(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IDefaultEnvironmentNameProvider> defaultEnvironmentNameProviderAction,
            IServiceAction<IEnvironmentNameConfigurationKeyProvider> environmentNameConfigurationKeyProviderAction)
        {
            var serviceAction = ServiceAction.New<IEnvironmentNameProvider>(() => services.AddEnvironmentNameProvider(
                configurationAction,
                defaultEnvironmentNameProviderAction,
                environmentNameConfigurationKeyProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentNameProvider"/> implementation of <see cref="IEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static EnvironmentNameProviderAggregation01 AddEnvironmentNameProviderAction(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IDefaultEnvironmentNameProvider> defaultEnvironmentNameProviderAction)
        {
            // Level 0.
            var environmentNameConfigurationKeyProviderAction = services.AddEnvironmentNameConfigurationKeyProviderAction();

            // Level 1.
            var environmentNameProviderAction = services.AddEnvironmentNameProviderAction(
                configurationAction,
                defaultEnvironmentNameProviderAction,
                environmentNameConfigurationKeyProviderAction);

            return new EnvironmentNameProviderAggregation01
            {
                EnvironmentNameConfigurationKeyProviderAction = environmentNameConfigurationKeyProviderAction,
                EnvironmentNameProviderAction = environmentNameProviderAction
            };
        }
    }
}
