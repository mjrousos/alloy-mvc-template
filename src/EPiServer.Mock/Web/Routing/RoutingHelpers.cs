using EPiServer.Core;
#if NETFRAMEWORK
using System.Web.Routing;
#endif
#if NETCOREAPP
using Microsoft.AspNetCore.Mvc;
#endif

namespace EPiServer.Web.Routing
{
    public static class RoutingHelpers
    {
#if NETFRAMEWORK
        public static ContentReference GetContentLink(this RequestContext context) => default;
#elif NETCOREAPP
        public static ContentReference GetContentLink(this ActionContext context) => default;
#endif
    }
}
