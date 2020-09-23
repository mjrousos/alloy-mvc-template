using System.Collections.Generic;
using System.Web;

namespace EPiServer.Web
{
    public interface IDisplayChannelService
    {
        IEnumerable<DisplayChannel> GetActiveChannels(HttpContextBase context);
    }
}
