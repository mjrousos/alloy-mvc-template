using EPiServer.Core;
#if NETFRAMEWORK
using System.Web.Routing;
#endif
#if NETCOREAPP
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
#endif

namespace EPiServer.Web.Routing
{
    public class PageRouteHelper : ContentRouteHelper, IPageRouteHelper, IContentRouteHelper
    {
        public PageRouteHelper(
#if NETFRAMEWORK
                                  RequestContext context,
#elif NETCOREAPP
                                  ActionContext context,
#endif
                                  RouteCollection routes,
                                  IViewContentRetriever viewContentRetriever,
                                  IContentLoader contentLoader)
            : base(context, routes, viewContentRetriever, contentLoader) { }

        public virtual PageData Page { get; }

        public virtual PageReference PageLink { get; }
    }
}
