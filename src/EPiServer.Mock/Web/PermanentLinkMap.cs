using EPiServer.Core;
using System;

namespace EPiServer.Web
{
    public class PermanentLinkMap
    {
        protected string Extension { get; set; }
        public ContentReference ContentReference { get; set; }
        public Guid Guid { get; protected set; }
        public bool HasMappedUrl { get; }
        public bool HasPermanentLinkUrl { get; }
        public bool IsMapped { get; }
        public Uri MappedUrl { get; }
        public Uri PermanentLinkUrl { get; protected set; }
    }
}
