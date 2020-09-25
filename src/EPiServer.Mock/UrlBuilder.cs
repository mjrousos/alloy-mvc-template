using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer
{
    public class UrlBuilder
    {
        public UrlBuilder(Url url) { }
        public UrlBuilder(UrlBuilder url) { }
        public UrlBuilder(string url) { }
        public UrlBuilder(Uri url) { }
        public Encoding Encoding { get; set; }
        public string Fragment { get; set; }
        public bool HasAuthorityPart { get; }
        public string Host { get; set; }
        public bool IsEmpty { get; }
        protected bool IsPathRelative { get; }
        public string Password { get; set; }
        public string Path { get; set; }
        public int Port { get; set; }
        public string Query { get; set; }
        public NameValueCollection QueryCollection { get; set; }
        public string QueryId { get; set; }
        public string QueryLanguage { get; set; }
        public string QueryTemplate { get; set; }
        public string Scheme { get; set; }
        protected UriBuilder ThisBuilder { get; set; }
        public Uri Uri { get; set; }
        public string UserName { get; set; }
        protected string MakeRelative(string fromBase, string path) => default;
        public void MergeQueryCollection(NameValueCollection masterQueryCollection) { }
        public bool Rebase(UrlBuilder fromBaseUrl, UrlBuilder toBaseUrl, UrlBuilder.RebaseKind kind) => default;

        [Flags]
        public enum RebaseKind
        {
            Default,
            IgnoreRootRelative,
            NoLeadingDotDot,
            ToRelative,
            ToRootRelative
        }
    }
}
