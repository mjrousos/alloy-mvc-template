using System;

namespace EPiServer.ServiceLocation
{
    public class ServiceConfigurationContext
    {
        public event EventHandler<ServiceConfigurationEventArgs> ConfigurationComplete;
        public IServiceConfigurationProvider Services { get; }
    }
}
