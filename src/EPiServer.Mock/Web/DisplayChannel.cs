using EPiServer.Framework.Localization;
#if NETFRAMEWORK
using System.Web;
#elif NETCOREAPP
using Microsoft.AspNetCore.Http;
#endif

namespace EPiServer.Web
{
    public abstract class DisplayChannel
    {
        public abstract string ChannelName { get; }
        public virtual string DisplayName { get; }
        public virtual LocalizationService LocalizationService { get; set; }
        protected virtual string NameLocalizationFormat { get; }
        public virtual string ResolutionId { get; }
#if NETFRAMEWORK
        public abstract bool IsActive(HttpContextBase context);
#elif NETCOREAPP
        public abstract bool IsActive(HttpContext context);
#endif

    }
}
