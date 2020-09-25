using System;

namespace EPiServer.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GroupDefinitionsAttribute : Attribute
    {
        public GroupDefinitionsAttribute() { }
    }
}
