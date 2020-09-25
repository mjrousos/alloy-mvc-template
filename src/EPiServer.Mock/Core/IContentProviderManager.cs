namespace EPiServer.Core
{
    public interface IContentProviderManager
    {
        ContentProviderMap ProviderMap { get; }
        ContentProvider GetProvider(string providerName);
        bool HasEntryPointChild(ContentReference contentLink);
        bool IsCapabilitySupported(ContentReference contentLink, ContentProviderCapabilities capability);
        bool IsWastebasket(ContentReference contentLink);
    }
}
