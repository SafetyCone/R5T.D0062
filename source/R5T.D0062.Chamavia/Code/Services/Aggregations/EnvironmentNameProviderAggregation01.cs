using System;

using R5T.Dacia;


namespace R5T.D0062.Chamavia
{
    public class EnvironmentNameProviderAggregation01
    {
        public IServiceAction<IEnvironmentNameConfigurationKeyProvider> EnvironmentNameConfigurationKeyProviderAction { get; set; }
        public IServiceAction<IEnvironmentNameProvider> EnvironmentNameProviderAction { get; set; }
    }
}
