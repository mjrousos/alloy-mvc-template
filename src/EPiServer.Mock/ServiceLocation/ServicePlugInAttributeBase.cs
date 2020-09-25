using System;
using System.Runtime.InteropServices;

namespace EPiServer.ServiceLocation
{
    public abstract class ServicePlugInAttributeBase : Attribute, _Attribute, IServiceConfiguration
    {
    }
}
