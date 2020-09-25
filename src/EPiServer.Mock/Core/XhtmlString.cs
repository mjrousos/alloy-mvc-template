#if NETFRAMEWORK
using System.Web;
#elif NETCOREAPP
using Microsoft.AspNetCore.Html;
#endif

namespace EPiServer.Core
{
    public class XhtmlString : HtmlString
    {
        public XhtmlString() : base(string.Empty) { }

        public XhtmlString(string value) : base(value) { }
    }
}
