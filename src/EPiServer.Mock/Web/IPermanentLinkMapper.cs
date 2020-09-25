using EPiServer.Core;
using System;

namespace EPiServer.Web
{
    public interface IPermanentLinkMapper
    {
        void Clear();
        PermanentContentLinkMap Find(ContentReference contentReference);
        PermanentLinkMap Find(UrlBuilder url);
        PermanentLinkMap Find(Guid guid);
    }
}
