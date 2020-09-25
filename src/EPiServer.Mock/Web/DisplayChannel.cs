using EPiServer.Framework.Localization;
using System.Web;

namespace EPiServer.Web
{
    public abstract class DisplayChannel
    {
        public abstract string ChannelName { get; }
        public virtual string DisplayName { get; }
        public virtual LocalizationService LocalizationService { get; set; }
        protected virtual string NameLocalizationFormat { get; }
        public virtual string ResolutionId { get; }
        public abstract bool IsActive(HttpContextBase context);
    }
}
