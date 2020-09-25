using System;
using System.Collections.Generic;

namespace EPiServer.Shell.ObjectEditing.EditorDescriptors
{
    public class EditorDescriptor
    {
        public EditorDescriptor() { }

        public IEnumerable<Type> AllowedTypes { get; set; }

        public string AllowedTypesFormatSuffix { get; set; }

        public string ClientEditingClass { get; set; }

        public string ClientEditingPackage { get; set; }

        public string DndSourcePropertyName { get; set; }

        public string DndTargetPropertyName { get; set; }

        public IDictionary<string, object> EditorConfiguration { get; }

        public string LayoutClass { get; set; }

        public IDictionary<string, object> OverlayConfiguration { get; }

        public Type SelectionFactoryType { get; set; }

        public virtual void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes) { }
    }
}
