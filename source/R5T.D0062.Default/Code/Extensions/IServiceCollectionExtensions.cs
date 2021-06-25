using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0062
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedDefaultEnvironmentNameProvider"/> implementation of <see cref="IDefaultEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedDefaultEnvironmentNameProvider(this IServiceCollection services,
            string defaultEnvironmentName)
        {
            services.AddSingleton<IDefaultEnvironmentNameProvider>(new ConstructorBasedDefaultEnvironmentNameProvider(defaultEnvironmentName));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedDefaultEnvironmentNameProvider"/> implementation of <see cref="IDefaultEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultEnvironmentNameProvider> AddConstructorBasedDefaultEnvironmentNameProviderAction(this IServiceCollection services,
            string defaultEnvironmentName)
        {
            var serviceAction = ServiceAction.New<IDefaultEnvironmentNameProvider>(() => services.AddConstructorBasedDefaultEnvironmentNameProvider(
                defaultEnvironmentName));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DevelopmentDefaultEnvironmentNameProvider"/> implementation of <see cref="IDefaultEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDevelopmentDefaultEnvironmentNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDefaultEnvironmentNameProvider, DevelopmentDefaultEnvironmentNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DevelopmentDefaultEnvironmentNameProvider"/> implementation of <see cref="IDefaultEnvironmentNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultEnvironmentNameProvider> AddDevelopmentDefaultEnvironmentNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IDefaultEnvironmentNameProvider>(() => services.AddDevelopmentDefaultEnvironmentNameProvider());
            return serviceAction;
        }
    }
}
