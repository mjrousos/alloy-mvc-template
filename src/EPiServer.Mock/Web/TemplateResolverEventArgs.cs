using EPiServer.DataAbstraction;
using EPiServer.Framework.Web;
using System;
using System.Collections.Generic;
using System.Web;

namespace EPiServer.Web
{
    public class TemplateResolverEventArgs: EventArgs
    {
        public TemplateResolverEventArgs(Type renderType, object itemToRender, IEnumerable<TemplateModel> templates, TemplateModel selectedTemplateModel, IEnumerable<string> tags) { }

        public TemplateResolverEventArgs(HttpContextBase httpContext, ContentType contentType, Type renderType, object itemToRender, IEnumerable<TemplateModel> templates, TemplateModel selectedTemplateModel, string tag) { }

        public ContentType ContentType { get; }

        public object ItemToRender { get; }

        public Type RenderType { get; }

        public TemplateTypeCategories RequestedCategory { get; set; }

        public TemplateModel SelectedTemplate { get; set; }

        public IEnumerable<TemplateModel> SupportedTemplates { get; }

        public string Tag { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public HttpContextBase WebContext { get; set; }
    }
}
