using System;
using System.Collections.Generic;

namespace EPiServer.ServiceLocation
{
    public interface IServiceLocator : IServiceProvider
    {
        IEnumerable<object> GetAllInstances(Type serviceType);

        object GetInstance(Type serviceType);

        TService GetInstance<TService>();
        bool TryGetExistingInstance(Type serviceType, out object instance);
    }
}
