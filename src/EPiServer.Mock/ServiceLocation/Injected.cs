namespace EPiServer.ServiceLocation
{
    public struct Injected<T>
        where T : class
    {
        public Injected(T service)
        {
            Service = service;
        }

        public T Service { get; set; }
    }
}
