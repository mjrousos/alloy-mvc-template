using EPiServer.ServiceLocation;
using System;

namespace EPiServer.Core
{
    [ServiceConfiguration]
    public class ContentProviderMap
    {
        public ContentProviderMap() { }
        public virtual bool CustomProvidersExist { get; }
        public virtual void AddProvider(ContentProvider provider) { }
        public virtual ContentProvider GetDefaultProvider() => default;
        public virtual ContentProvider GetProvider(ContentReference contentLink) => default;
        public virtual ContentProvider GetProvider(string providerId) => default;
        public virtual bool IsEntryPoint(ContentReference contentLink) => default;
        public void Iterate(Action<ContentProvider> contentProviderHandler) { }
        public void Iterate(Func<ContentProvider, bool> contentProviderFunction) { }
        public virtual bool RemoveProvider(string providerName) => default;
    }
}
