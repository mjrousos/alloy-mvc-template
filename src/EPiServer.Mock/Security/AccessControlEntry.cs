using System;

namespace EPiServer.Security
{
    public class AccessControlEntry : IEquatable<AccessControlEntry>
    {
        public AccessControlEntry(string name, AccessLevel access) { }

        public bool Equals(AccessControlEntry other) => default;
    }
}
