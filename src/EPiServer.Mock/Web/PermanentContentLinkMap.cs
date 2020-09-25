using EPiServer.Core;
using System;

namespace EPiServer.Web
{
    public class PermanentContentLinkMap : PermanentLinkMap
    {
        public PermanentContentLinkMap(Guid guid, string extension, Uri mappedUrl, ContentReference contentReference, PageMapSettings settings) { }
        protected PermanentContentLinkMap(Uri url) { }
        public PageMapSettings PageMapSettings { get; protected set; }

    }
}
