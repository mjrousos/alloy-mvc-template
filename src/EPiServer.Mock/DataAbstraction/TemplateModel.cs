using EPiServer.Framework.Web;
using System;

namespace EPiServer.DataAbstraction
{
    public class TemplateModel
    {
        public bool AvailableWithoutTag { get; set; }

        public bool Default { get; set; }

        public string Description { get; set; }

        public string DisplayName { get; set; }

        public bool Inherit { get; set; }

        public bool Inherited { get; set; }

        public bool IsReadOnly { get; protected set; }

        public Type ModelType { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string[] Tags { get; set; }

        public Type TemplateType { get; set; }

        public TemplateTypeCategories TemplateTypeCategory { get; set; }
    }
}
