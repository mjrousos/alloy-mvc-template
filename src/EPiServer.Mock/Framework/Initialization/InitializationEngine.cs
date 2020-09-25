using EPiServer.ServiceLocation;

namespace EPiServer.Framework.Initialization
{
    public class InitializationEngine : IInitializationEngine
    {
        public HostType HostType { get; }

        public ServiceLocationHelper Locate { get; set; }
    }
}
