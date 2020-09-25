using System;

namespace EPiServer.PlugIn
{
    public abstract class PlugInAttribute : Attribute
    {
        protected PlugInAttribute() { }

        protected PlugInAttribute(string displayName, string description) { }

        protected PlugInAttribute(string displayName, string description, string languagePath) { }

        public string Description { get; set; }

        public string DisplayName { get; set; }
    }
}
