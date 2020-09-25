using EPiServer.ServiceLocation;
using System.Web.Mvc;

namespace EPiServer.Web.Mvc
{
    [ServiceConfiguration(IncludeServiceAccessor = false)]
    public class PartialRequest
    {
        public PartialRequest() { }
        public virtual void RenderAction(HtmlHelper helper, string action, string controller, object routeValues) { }
    }
}
