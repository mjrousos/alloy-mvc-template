using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using System.Web.Mvc;

namespace EPiServer.Web.Mvc
{
    [ServiceConfiguration(IncludeServiceAccessor = false)]
    public class MvcContentRenderer: IContentRenderer
    {
        public MvcContentRenderer() { }
        public virtual void Render(HtmlHelper helper, PartialRequest partialRequestHandler, IContentData contentData, TemplateModel templateModel) { }
    }
}
