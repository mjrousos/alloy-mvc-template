using EPiServer.Data.Entity;

namespace EPiServer.Security
{
    public interface IEditableSecurityDescriptor : ISecurityDescriptor, IReadOnly
    {
        void AddEntry(AccessControlEntry accessControlEntry);
    }
}
