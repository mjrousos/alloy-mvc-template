using System;

namespace EPiServer.DataAbstraction
{
    public interface IContentTypeRepository<T>
        where T : ContentType
    {
        T Copy(T contentType);
        T Copy(int id);
        T Load(Guid guid);
        T Load(int id);
        T Load(string name);
        T Load(Type modelType);
    }
}
