using System;

namespace EPiServer.ServiceLocation
{
    public sealed class ServiceConfigurationAttribute : Attribute, IServiceConfiguration
    {
        public ServiceConfigurationAttribute() { }

        public ServiceConfigurationAttribute(Type serviceType) { }

        public bool IncludeServiceAccessor { get; set; }
    }
}
