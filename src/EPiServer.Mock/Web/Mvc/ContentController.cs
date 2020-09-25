using EPiServer.Core;

namespace EPiServer.Web.Mvc
{
    public abstract class ContentController<T> : ActionControllerBase, IRenderTemplate<T>, IRenderTemplate where T : IContent
    {
    }
}
