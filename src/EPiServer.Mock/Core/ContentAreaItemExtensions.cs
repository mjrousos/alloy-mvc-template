using EPiServer.Web;

namespace EPiServer.Core
{
    public static class ContentAreaItemExtensions
    {
        public static IContent GetContent(this ContentAreaItem item) => default;

        public static DisplayOption LoadDisplayOption(this ContentAreaItem contentAreaItem) => default;

        public static DisplayOption LoadDisplayOption(this ContentAreaItem contentAreaItem, DisplayOptions displayOptions) => default;
    }
}
