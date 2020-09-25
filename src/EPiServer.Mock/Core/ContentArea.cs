using System.Collections.Generic;

namespace EPiServer.Core
{
    public class ContentArea : XhtmlString
    {
        public ContentArea() { }

        public ContentArea(string unparsedString) : base(unparsedString) { }

        public virtual IList<ContentAreaItem> Items { get; }
    }
}
