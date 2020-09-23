using EPiServer.DataAbstraction;
using System;
using System.Runtime.InteropServices;

namespace EPiServer.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AvailableContentTypesAttribute : Attribute, _Attribute, IContentTypeAvailableModelSetting
    {
        public AvailableContentTypesAttribute(Availability availability) { }

        public Type[] Exclude { get; set; }

        public Type[] ExcludeOn { get; set; }


        public Type[] Include { get; set; }

        public Type[] IncludeOn { get; set; }
    }
}
