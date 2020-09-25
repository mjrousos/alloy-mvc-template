#if NETFRAMEWORK
using System;
using System.Web;
using System.Web.Routing;

namespace EPiServer
{
    public class Global : SiteBase
    {
        public Global() { }
        public static string BaseDirectory { get; set; }
        public static bool DesignTimeLiveDataAvailable { get; }
        public static string InstanceName { get; set; }
        public static bool IsDesignTime { get; }
        public static bool IsUnitTest { get; }
        public override string GetVaryByCustomString(HttpContext context, string custom) => default;
        protected virtual void Global_PreRequestHandlerExecute(object sender, EventArgs e) { }
        protected virtual void HandleAccessDenied() { }
        public override void Init() { }
        protected virtual void OnRoutesRegistered(RouteCollection routes) { }
        protected virtual void OnRoutesRegistrating(RouteCollection routes) { }
        protected virtual void RegisterRoutes(RouteCollection routes) { }
    }
}
#endif
