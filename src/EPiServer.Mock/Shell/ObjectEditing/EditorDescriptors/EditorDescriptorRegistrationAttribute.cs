using EPiServer.ServiceLocation;
using System;

namespace EPiServer.Shell.ObjectEditing.EditorDescriptors
{
    public sealed class EditorDescriptorRegistrationAttribute : ServicePlugInAttributeBase, IServiceConfiguration
    {
        public EditorDescriptorRegistrationAttribute() { }

        public EditorDescriptorBehavior EditorDescriptorBehavior { get; set; }

        public Type TargetType { get; set; }

        public string UIHint { get; set; }
    }
}
