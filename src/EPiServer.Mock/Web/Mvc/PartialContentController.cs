using EPiServer.Core;
using System.Web.Mvc;

namespace EPiServer.Web.Mvc
{
    public abstract class PartialContentController<TContentData> : ActionControllerBase, IRenderTemplate<TContentData>, IRenderTemplate where TContentData : IContentData
    {
        public virtual ActionResult Index(TContentData currentContent) => default;
    }
}
