using EPiServer.Framework;
using EPiServer.ServiceLocation;
using AlloyTemplates.Business.Rendering;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AlloyTemplates.Business.Initialization
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public static void ConfigureContainer(IServiceCollection context)
        {
            //Implementations for custom interfaces can be registered here.
            context.RemoveAll<IContentRenderer>();
            context.RemoveAll<ContentAreaRenderer>();
            context.AddTransient<IContentRenderer, ErrorHandlingContentRenderer>();
            context.AddTransient<ContentAreaRenderer, AlloyContentAreaRenderer>();
        }
    }
}
