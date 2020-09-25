using System;

namespace EPiServer.Web
{
    public class PageMapSettings
    {
        public PageMapSettings(Uri siteUri, string urlRewriteExtension) { }
        public Uri SiteUrl { get; }
        public string UrlRewriteExtension { get; }
    }
}
