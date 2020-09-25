using System;

namespace EPiServer.ServiceLocation
{
    public static class ServiceConfigurationProviderExtensions
    {
        public static IRegisteredService AddTransient<TService, TImplementation>(this IServiceConfigurationProvider services)
            where TService : class where TImplementation : class, TService => default;

        public static IServiceConfigurationProvider Configure<TService>(this IServiceConfigurationProvider services, Action<TService> configure)
            where TService : class => default;
    }
}
