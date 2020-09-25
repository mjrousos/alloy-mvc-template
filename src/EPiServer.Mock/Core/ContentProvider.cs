using EPiServer.Web;
using System.Configuration.Provider;

namespace EPiServer.Core
{
    public abstract class ContentProvider : ProviderBase, IContentResolver
    {
        public ContentProvider() { }
        public virtual string ProviderKey { get; }

        public ContentResolveResult ResolveContent(ContentReference contentLink) => default;
        public bool HasCapability(ContentProviderCapabilities contentProviderCapabilities) => default;
    }
}
