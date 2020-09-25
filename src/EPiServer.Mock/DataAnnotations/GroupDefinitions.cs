using System;
using System.Runtime.InteropServices;

namespace EPiServer.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GroupDefinitionsAttribute : Attribute, _Attribute
    {
        public GroupDefinitionsAttribute() { }
    }
}
