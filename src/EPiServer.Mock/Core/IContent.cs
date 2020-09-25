using System;

namespace EPiServer.Core
{
    public interface IContent: IContentData
    {
        Guid ContentGuid { get; set; }

        ContentReference ContentLink { get; set; }

        int ContentTypeID { get; set; }

        bool IsDeleted { get; set; }

        string Name { get; set; }

        ContentReference ParentLink { get; set; }
    }
}
