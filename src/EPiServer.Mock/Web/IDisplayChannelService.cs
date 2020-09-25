using System.Collections.Generic;
#if NETFRAMEWORK
using System.Web;
#elif NETCOREAPP
using Microsoft.AspNetCore.Http;
#endif

namespace EPiServer.Web
{
    public interface IDisplayChannelService
    {
#if NETFRAMEWORK
        IEnumerable<DisplayChannel> GetActiveChannels(HttpContextBase context);
#elif NETCOREAPP
        IEnumerable<DisplayChannel> GetActiveChannels(HttpContext context);
#endif
    }
}
