using System;

using R5T.T0022;


namespace R5T.D0062.Chamavia
{
    public static class IConfigurationSectionNamesExtensions
    {
#pragma warning disable IDE0060 // Remove unused parameter

        public static string GetEnvironmentName(this IConfigurationSectionNames configurationSectionNames)
        {
            return "EnvironmentName";
        }

#pragma warning restore IDE0060 // Remove unused parameter
    }
}
