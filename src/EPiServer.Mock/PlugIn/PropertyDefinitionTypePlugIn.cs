using System;
using System.Runtime.InteropServices;

namespace EPiServer.PlugIn
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PropertyDefinitionTypePlugInAttribute : PlugInAttribute, _Attribute
    {
        public PropertyDefinitionTypePlugInAttribute() { }

    }
}
