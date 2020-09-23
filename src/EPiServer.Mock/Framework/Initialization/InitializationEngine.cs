using EPiServer.ServiceLocation;

namespace EPiServer.Framework.Initialization
{
    public class InitializationEngine : IInitializationEngine
    {
        public ServiceLocationHelper Locate { get; set; }
    }
}
