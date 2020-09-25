using System;
using System.Runtime.InteropServices;

namespace EPiServer.ServiceLocation
{
    public sealed class ServiceConfigurationAttribute : Attribute, _Attribute, IServiceConfiguration
    {
        public ServiceConfigurationAttribute() { }

        public ServiceConfigurationAttribute(Type serviceType) { }

        public bool IncludeServiceAccessor { get; set; }
    }
}
