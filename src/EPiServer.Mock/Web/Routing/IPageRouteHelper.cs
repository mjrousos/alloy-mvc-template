using EPiServer.Core;

namespace EPiServer.Web.Routing
{
    public interface IPageRouteHelper : IContentRouteHelper
    {
        PageData Page { get; }

        PageReference PageLink { get; }
    }
}
