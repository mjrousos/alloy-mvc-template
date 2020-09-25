using EPiServer.DataAbstraction;

namespace EPiServer.Core
{
    public abstract class ContentData: IContentData
    {
        public virtual object this[string index] { get => default; set { } }

        public virtual void SetDefaultValues(ContentType contentType) { }

        public virtual PropertyDataCollection Property { get; protected set; }
    }
}
