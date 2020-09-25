using EPiServer.DataAbstraction;
using EPiServer.Framework.Web;
using System;
using System.Collections.Generic;
#if NETFRAMEWORK
using System.Web;
#elif NETCOREAPP
using Microsoft.AspNetCore.Http;
#endif

namespace EPiServer.Web
{
    public class TemplateResolverEventArgs: EventArgs
    {
        public TemplateResolverEventArgs(Type renderType, object itemToRender, IEnumerable<TemplateModel> templates, TemplateModel selectedTemplateModel, IEnumerable<string> tags) { }

#if NETFRAMEWORK
        public TemplateResolverEventArgs(HttpContextBase httpContext, ContentType contentType, Type renderType, object itemToRender, IEnumerable<TemplateModel> templates, TemplateModel selectedTemplateModel, string tag) { }
#elif NETCOREAPP
        public TemplateResolverEventArgs(HttpContext httpContext, ContentType contentType, Type renderType, object itemToRender, IEnumerable<TemplateModel> templates, TemplateModel selectedTemplateModel, string tag) { }
#endif

        public ContentType ContentType { get; }

        public object ItemToRender { get; }

        public Type RenderType { get; }

        public TemplateTypeCategories RequestedCategory { get; set; }

        public TemplateModel SelectedTemplate { get; set; }

        public IEnumerable<TemplateModel> SupportedTemplates { get; }

        public string Tag { get; set; }

        public IEnumerable<string> Tags { get; set; }
#if NETFRAMEWORK
        public HttpContextBase WebContext { get; set; }
#elif NETCOREAPP
        public HttpContext WebContext { get; set; }
#endif
    }
}
