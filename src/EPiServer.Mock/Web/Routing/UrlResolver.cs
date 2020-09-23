using EPiServer.Core;
using System.Collections.Generic;

namespace EPiServer.Web.Routing
{
    public abstract class UrlResolver
    {
        public static UrlResolver Current { get; }

        public static IEnumerable<string> RoutedQueryParameters { get; }

        // protected abstract bool ConvertToPermanent(UrlBuilder url, IContent content);

        public virtual string GetPermanent(string url, bool enableFallback) => default;

        public virtual string GetUrl(ContentReference contentLink) => default;
    }
}
