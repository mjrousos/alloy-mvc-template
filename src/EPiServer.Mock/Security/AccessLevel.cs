using System;

namespace EPiServer.Security
{
    [Flags]
    public enum AccessLevel
    {
        Administer,
        Create,
        Delete,
        Edit,
        FullAccess,
        NoAccess,
        Publish,
        Read,
        Undefined
    }
}
