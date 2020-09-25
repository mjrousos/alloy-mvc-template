using System;

namespace EPiServer.Core
{
    public class PageData : ContentData, IContent, IContentData
    {
        public virtual CategoryList Category { get; set; }

        public virtual int ContentTypeID { get; set; }

        public virtual ContentReference ParentLink { get; set; }
        public Guid ContentGuid { get; set; }
        public ContentReference ContentLink { get; set; }
        public virtual PageShortcutType LinkType { get; set; }
        public virtual string LinkURL { get; set; }
        public virtual PageReference PageLink { get; set; }
        public virtual string PageName { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public virtual bool VisibleInMenu { get; set; }
    }
}
