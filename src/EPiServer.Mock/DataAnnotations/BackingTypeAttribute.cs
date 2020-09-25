using System;

namespace EPiServer.DataAnnotations
{
    public class BackingTypeAttribute : Attribute
    {
        public Type BackingType { get; }

        public BackingTypeAttribute(Type backingType) { }
    }
}
