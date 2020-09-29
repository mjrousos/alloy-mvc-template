using EPiServer.Core;
#if NETFRAMEWORK
using System.Web.Mvc;
#elif NETCOREAPP
using Microsoft.AspNetCore.Mvc.ViewFeatures;
#endif

namespace EPiServer.Web.Mvc.Html
{
    public class ContentAreaRenderer
    {
        protected IContentRepository ContentRepository { get; }

        protected virtual string GetContentAreaItemTemplateTag(HtmlHelper htmlHelper, ContentAreaItem contentAreaItem) => default;

        protected virtual string GetContentAreaItemCssClass(HtmlHelper htmlHelper, ContentAreaItem contentAreaItem) => default;
    }
}
