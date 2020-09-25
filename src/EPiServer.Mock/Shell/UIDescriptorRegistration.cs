using EPiServer.ServiceLocation;

namespace EPiServer.Shell
{
    public sealed class UIDescriptorRegistrationAttribute : ServicePlugInAttributeBase, IServiceConfiguration
    {
        public UIDescriptorRegistrationAttribute() { }
    }
}
