using EPiServer.Framework.Localization;

namespace EPiServer.Web
{
    public abstract class DisplayChannel
    {
        public abstract string ChannelName { get; }
        public virtual string DisplayName { get; }
        public virtual LocalizationService LocalizationService { get; set; }
        protected virtual string NameLocalizationFormat { get; }
        public virtual string ResolutionId { get; }
    }
}
