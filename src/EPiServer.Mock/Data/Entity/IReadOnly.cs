namespace EPiServer.Data.Entity
{
    public interface IReadOnly
    {
        object CreateWritableClone();
    }
}
