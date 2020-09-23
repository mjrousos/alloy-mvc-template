using System;

namespace EPiServer.ServiceLocation
{
    public interface IServiceLocator : IServiceProvider
    {
        TService GetInstance<TService>();
    }
}
