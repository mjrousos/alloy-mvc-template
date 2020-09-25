using EPiServer.DataAbstraction;
using EPiServer.Framework.Web;
using System;
#if NETFRAMEWORK
using System.Web;
#elif NETCOREAPP
using Microsoft.AspNetCore.Http;
#endif

namespace EPiServer.Web
{
    public abstract class TemplateResolver : ITemplateResolver, ITemplateResolverEvents
    {
#if NETFRAMEWORK
        public virtual TemplateModel Resolve(HttpContextBase httpContext, Type itemType, object itemToRender, TemplateTypeCategories templateTypeCategory, string tag)
            => default;
#elif NETCOREAPP
        public virtual TemplateModel Resolve(HttpContext httpContext, Type itemType, object itemToRender, TemplateTypeCategories templateTypeCategory, string tag)
            => default;
#endif

        public event EventHandler<TemplateResolverEventArgs> TemplateResolved;
        public event EventHandler<TemplateResolverEventArgs> TemplateResolving;
    }
}
