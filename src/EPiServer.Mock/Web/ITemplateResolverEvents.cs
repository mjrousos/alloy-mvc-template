using System;

namespace EPiServer.Web
{
    public interface ITemplateResolverEvents
    {
        event EventHandler<TemplateResolverEventArgs> TemplateResolved;
        event EventHandler<TemplateResolverEventArgs> TemplateResolving;
    }
}
