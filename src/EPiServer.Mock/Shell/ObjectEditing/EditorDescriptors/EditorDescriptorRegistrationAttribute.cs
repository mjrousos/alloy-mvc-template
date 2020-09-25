using EPiServer.ServiceLocation;
using System;
using System.Runtime.InteropServices;

namespace EPiServer.Shell.ObjectEditing.EditorDescriptors
{
    public sealed class EditorDescriptorRegistrationAttribute : ServicePlugInAttributeBase, _Attribute, IServiceConfiguration
    {
        public EditorDescriptorRegistrationAttribute() { }

        public EditorDescriptorBehavior EditorDescriptorBehavior { get; set; }

        public Type TargetType { get; set; }

        public string UIHint { get; set; }
    }
}
