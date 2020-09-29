using System;
using EPiServer.Web;
using Microsoft.AspNetCore.Http;

namespace AlloyTemplates.Business.Channels
{
    //<summary>
    //Defines the 'Mobile' content channel
    //</summary>
    public class MobileChannel : DisplayChannel
    {
        public const string Name = "mobile";

        public override string ChannelName
        {
            get
            {
                return Name;
            }
        }

        public override string ResolutionId
        {
            get
            {
                return typeof(IphoneVerticalResolution).FullName;
            }
        }

        public override bool IsActive(HttpContext context)
        {
            // TODO
            // return context.GetOverriddenBrowser().IsMobileDevice;

            throw new NotImplementedException();
        }
    }
}
