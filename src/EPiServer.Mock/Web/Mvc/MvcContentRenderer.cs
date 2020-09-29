using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
#if NETFRAMEWORK
using System.Web.Mvc;
#elif NETCOREAPP
using Microsoft.AspNetCore.Mvc.ViewFeatures;
#endif

namespace EPiServer.Web.Mvc
{
    [ServiceConfiguration(IncludeServiceAccessor = false)]
    public class MvcContentRenderer: IContentRenderer
    {
        public MvcContentRenderer() { }
        public virtual void Render(HtmlHelper helper, PartialRequest partialRequestHandler, IContentData contentData, TemplateModel templateModel) { }
    }
}
