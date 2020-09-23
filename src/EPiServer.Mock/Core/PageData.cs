namespace EPiServer.Core
{
    public class PageData : ContentData, IContent, IContentData
    {
        public virtual CategoryList Category { get; set; }

        public virtual int ContentTypeID { get; set; }

        public virtual ContentReference ParentLink { get; set; }
    }
}
