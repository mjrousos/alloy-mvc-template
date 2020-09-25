namespace EPiServer.Shell.Security
{
    public interface IUIRole
    {
        string Name { get; set; }
        string ProviderName { get; set; }
    }
}
