using EPiServer.Core;
using System;

namespace EPiServer.Web
{
    public class ContentResolveResult
    {
        public ContentResolveResult() { }
        public ContentReference ContentLink { get; set; }
        public Uri ContentUri { get; set; }
        public Guid UniqueID { get; set; }
    }
}
