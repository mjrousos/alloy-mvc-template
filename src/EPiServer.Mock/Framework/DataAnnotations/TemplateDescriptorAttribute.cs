using EPiServer.Framework.Web;
using System;

namespace EPiServer.Framework.DataAnnotations
{
    public class TemplateDescriptorAttribute : Attribute
    {
        public TemplateDescriptorAttribute() { }
        public TemplateDescriptorAttribute(Type modelType) { }

        public bool AvailableWithoutTag { get; set; }

        public bool Default { get; set; }

        public string Description { get; set; }

        public bool Inherited { get; set; }

        public Type ModelType { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string[] Tags { get; set; }

        public string TagString { get; set; }

        public TemplateTypeCategories TemplateTypeCategory { get; set; }
    }
}
