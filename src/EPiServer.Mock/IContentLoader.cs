using EPiServer.Core;
using System.Collections.Generic;

namespace EPiServer
{
    public interface IContentLoader
    {
        T Get<T>(ContentReference contentLink)
            where T : IContentData;

        IEnumerable<T> GetChildren<T>(ContentReference contentLink)
            where T : IContentData;

        IEnumerable<IContent> GetAncestors(ContentReference contentLink);
    }
}
