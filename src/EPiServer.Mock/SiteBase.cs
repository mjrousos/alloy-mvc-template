using System;
using System.Web;

namespace EPiServer
{
    public class SiteBase : HttpApplication
    {
        public bool IsDefaultDocumentsEnabled { get; set; }
        protected virtual string[] GetDefaultDocuments(Uri url) => default;
        protected virtual bool SchemeHostPortMatch(Uri url1, Uri url2) => default;
    }
}
