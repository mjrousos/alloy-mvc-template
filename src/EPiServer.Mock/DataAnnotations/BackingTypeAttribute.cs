using System;
using System.Runtime.InteropServices;

namespace EPiServer.DataAnnotations
{
    public class BackingTypeAttribute : Attribute, _Attribute
    {
        public Type BackingType { get; }

        public BackingTypeAttribute(Type backingType) { }
    }
}
