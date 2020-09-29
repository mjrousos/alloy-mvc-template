#if NETFRAMEWORK
using System.Web.Mvc;
#elif NETCOREAPP
using Microsoft.AspNetCore.Mvc;
#endif

namespace EPiServer.Web.Mvc
{
    public abstract class ActionControllerBase : Controller, IRenderTemplate

    {
    }
}
