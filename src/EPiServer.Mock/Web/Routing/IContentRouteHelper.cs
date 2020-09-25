using EPiServer.Core;

namespace EPiServer.Web.Routing
{
    public interface IContentRouteHelper
    {
        IContent Content { get; }

        ContentReference ContentLink { get; }

        string LanguageID { get; }
    }
}
