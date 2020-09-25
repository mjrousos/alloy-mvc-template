using EPiServer.Core;
using System.Web.Routing;

namespace EPiServer.Web.Routing
{
    public class ContentRouteHelper : IContentRouteHelper
    {
        public ContentRouteHelper(RequestContext context, RouteCollection routes, IViewContentRetriever viewContentRetriever, IContentLoader contentLoader) { }

        public virtual IContent Content { get; }

        public virtual ContentReference ContentLink { get; }

        protected IViewContentRetriever ContentRetriever { get; }

        public virtual string LanguageID { get; }

        protected RequestContext RequestContext { get; }

        protected virtual void SetRouteDataIfPageNotRouted() { }
    }
}
