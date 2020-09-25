using EPiServer.Core;
#if NETFRAMEWORK
using System.Web.Routing;
#elif NETCOREAPP
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
#endif

namespace EPiServer.Web.Routing
{
    public class ContentRouteHelper : IContentRouteHelper
    {
        public ContentRouteHelper(
#if NETFRAMEWORK
                                  RequestContext context,
#elif NETCOREAPP
                                  ActionContext context,
#endif
                                  RouteCollection routes,
                                  IViewContentRetriever viewContentRetriever,
                                  IContentLoader contentLoader) { }

        public virtual IContent Content { get; }

        public virtual ContentReference ContentLink { get; }

        protected IViewContentRetriever ContentRetriever { get; }

        public virtual string LanguageID { get; }

#if NETFRAMEWORK
        protected RequestContext RequestContext { get; }
#elif NETCOREAPP
        protected ActionContext RequestContext { get; }
#endif

        protected virtual void SetRouteDataIfPageNotRouted() { }
    }
}
