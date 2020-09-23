namespace EPiServer.Core
{
    public interface IContent: IContentData
    {
        ContentReference ParentLink { get; set; }
    }
}
