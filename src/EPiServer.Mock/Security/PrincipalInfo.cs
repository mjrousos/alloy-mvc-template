using System.Collections.Generic;
using System.Security.Principal;

namespace EPiServer.Security
{
    public class PrincipalInfo
    {
        public PrincipalInfo(IPrincipal principal) { }
        public static IPrincipal AnonymousPrincipal { get; }
        public static PrincipalInfo Current { get; }
        public static IPrincipal CurrentPrincipal { get; set; }
        public static bool HasAdminAccess { get; }
        public static bool HasEditAccess { get; }
        public static bool HasEditorAccess { get; }
        public string Name { get; }
        public IPrincipal Principal { get; }
        public ICollection<string> RoleList { get; }
        public static IPrincipal CreatePrincipal(string username) => default;
        public virtual bool HasPathAccess(string path) => default;
    }
}
