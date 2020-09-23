using System.Web.Mvc;

namespace EPiServer.Framework.Web.Mvc
{
    public class RequireClientResourcesAttribute: ActionFilterAttribute
    {
        public RequireClientResourcesAttribute() { }

        public override void OnResultExecuting(ResultExecutingContext filterContext) { }
    }
}
