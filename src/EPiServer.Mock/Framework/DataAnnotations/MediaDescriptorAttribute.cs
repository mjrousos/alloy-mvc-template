using System;

namespace EPiServer.Framework.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class MediaDescriptorAttribute : Attribute
    {
        public MediaDescriptorAttribute() { }

        public string[] Extensions { get; set; }

        public string ExtensionString { get; set; }
    }
}
