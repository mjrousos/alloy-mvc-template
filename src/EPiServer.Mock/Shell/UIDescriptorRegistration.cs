using EPiServer.ServiceLocation;
using System.Runtime.InteropServices;

namespace EPiServer.Shell
{
    public sealed class UIDescriptorRegistrationAttribute : ServicePlugInAttributeBase, _Attribute, IServiceConfiguration
    {
        public UIDescriptorRegistrationAttribute() { }
    }
}
