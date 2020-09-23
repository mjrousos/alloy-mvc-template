using System.Web;

namespace EPiServer.Core
{
    public class XhtmlString : HtmlString
    {
        public XhtmlString() : base(string.Empty) { }

        public XhtmlString(string value) : base(value) { }
    }
}
