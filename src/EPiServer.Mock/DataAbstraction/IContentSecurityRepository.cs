using EPiServer.Core;
using EPiServer.Security;
using System;

namespace EPiServer.DataAbstraction
{
    public interface IContentSecurityRepository
    {
        void Delete(string userOrRoleName, SecurityEntityType entityUserRole);

        IContentSecurityDescriptor Get(ContentReference contentLink);

        void Save(ContentReference ContentLink, IContentSecurityDescriptor contentSecurityDescriptor, SecuritySaveType securitySaveType);

        event EventHandler<ContentSecurityEventArg> ContentSecuritySaved;
    }
}
