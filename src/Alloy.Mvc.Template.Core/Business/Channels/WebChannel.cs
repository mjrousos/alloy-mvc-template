using EPiServer.Web;
using Microsoft.AspNetCore.Http;
using System;

namespace AlloyTemplates.Business.Channels
{
    /// <summary>
    /// Defines the 'Web' content channel
    /// </summary>
    public class WebChannel : DisplayChannel
    {
        public override string ChannelName
        {
            get
            {
                return "web";
            }
        }

        public override bool IsActive(HttpContext context)
        {
            // TODO
            // return !context.Request.Browser.IsMobileDevice;
            throw new NotImplementedException();
        }
    }
}
