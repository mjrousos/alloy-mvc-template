using System;

namespace EPiServer.Core
{
    public class MediaData : ContentBase, IContent, IContentData

    {
        public MediaData() { }
        public Guid ContentGuid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ContentReference ContentLink { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ContentTypeID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ContentReference ParentLink { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
