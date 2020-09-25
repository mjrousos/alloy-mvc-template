using EPiServer.DataAbstraction;
using EPiServer.Framework.Web;
using System;
using System.Web;

namespace EPiServer.Web
{
    public abstract class TemplateResolver : ITemplateResolver, ITemplateResolverEvents
    {
        public virtual TemplateModel Resolve(HttpContextBase httpContext, Type itemType, object itemToRender, TemplateTypeCategories templateTypeCategory, string tag)
            => default;

        public event EventHandler<TemplateResolverEventArgs> TemplateResolved;
        public event EventHandler<TemplateResolverEventArgs> TemplateResolving;
    }
}
