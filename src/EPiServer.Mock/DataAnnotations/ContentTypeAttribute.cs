using System;

namespace EPiServer.DataAnnotations
{
    public class ContentTypeAttribute : Attribute
    {
        public string GroupName { get; set; }
        public string GUID { get; set; }

        public bool AvailableInEditMode { get; set; }
    }
}
