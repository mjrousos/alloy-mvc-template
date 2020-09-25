using EPiServer.Core;
using EPiServer.Web.Routing;

namespace EPiServer.Web.Mvc
{
    public abstract class PageController<T> : ContentController<T>, IRenderTemplate<T>, IRenderTemplate where T : PageData
    {
        public virtual PageRouteHelper PageContext { get; set; }
    }
}
