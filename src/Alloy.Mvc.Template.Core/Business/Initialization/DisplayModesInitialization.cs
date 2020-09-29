using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using AlloyTemplates.Business.Channels;
using EPiServer.Web;
using Microsoft.AspNetCore.Http;

namespace AlloyTemplates.Business.Initialization
{
    /// <summary>
    /// Adds a new display mode for mobile which is active if the mobile channel is active in addition to if the request is from a mobile device (like the default one)
    /// </summary>
    /// <remarks>
    /// It's also possible to map a display mode as a channel through the DisplayChannelService.RegisterDisplayMode() method.
    /// Adding channels that way does not however enable specifying ResolutionId which we want to do for the mobile channel.
    /// </remarks>
    // [ModuleDependency(typeof(InitializationModule))]
    public class DisplayModesInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            // TODO : Should be implemented with IViewLocationExpander and custom middleware to check user agent header
            //var mobileChannelDisplayMode = new DefaultDisplayMode("mobile")
            //{
            //    ContextCondition = IsMobileDisplayModeActive
            //};
            //DisplayModeProvider.Instance.Modes.Insert(0, mobileChannelDisplayMode);
        }

        //private static bool IsMobileDisplayModeActive(HttpContext httpContext)
        //{
        //    if (httpContext.GetOverriddenBrowser().IsMobileDevice)
        //    {
        //        return true;
        //    }
        //    var displayChannelService = ServiceLocator.Current.GetInstance<IDisplayChannelService>();
        //    return displayChannelService.GetActiveChannels(httpContext).Any(x => x.ChannelName == MobileChannel.Name);
        //}

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
