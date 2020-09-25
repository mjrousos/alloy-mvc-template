using EPiServer.Core;
using System.Web.Routing;

namespace EPiServer.Web.Routing
{
    public class PageRouteHelper : ContentRouteHelper, IPageRouteHelper, IContentRouteHelper
    {
        public PageRouteHelper(RequestContext context, RouteCollection routes, IViewContentRetriever viewContentRetriever, IContentLoader contentLoader)
            : base(context, routes, viewContentRetriever, contentLoader) { }

        public virtual PageData Page { get; }

        public virtual PageReference PageLink { get; }
    }
}
