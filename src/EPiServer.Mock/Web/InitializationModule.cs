#if NETFRAMEWORK
using EPiServer.Framework;
using EPiServer.ServiceLocation;
using System.Web;

namespace EPiServer.Web
{
    public class InitializationModule : IHttpModule, IInitializableModule, IConfigurableModule
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
        }
    }
}
#endif
