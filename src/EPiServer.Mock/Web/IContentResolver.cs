using EPiServer.Core;

namespace EPiServer.Web
{
    public interface IContentResolver
    {
        ContentResolveResult ResolveContent(ContentReference contentLink);
    }
}
