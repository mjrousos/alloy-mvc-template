using EPiServer.Security;
using System;
using System.Collections.Generic;

namespace EPiServer.Shell.Security
{
    public abstract class UIRoleProvider : IDisposable
    {
        protected UIRoleProvider() { }
        public abstract bool Enabled { get; set; }
        public abstract string Name { get; }
        public abstract void AddUserToRoles(string username, IEnumerable<string> roleNames);
        public abstract void CreateRole(string newRoleName);
        public abstract bool DeleteRole(string roleName, bool throwOnPopulatedRole);
        public virtual bool DeleteRole(string providerName, string roleName, bool throwOnPopulatedRole) => default;
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract IEnumerable<IUIRole> GetAllRoles();
        public abstract IEnumerable<string> GetAllRolesForUser(string userName);
        public virtual string GetRoleProviderName(string name) => default;
        public abstract IEnumerable<string> GetRolesForUser(string username);
        public abstract IEnumerable<string> GetUsersInRole(string roleName);
        public virtual IEnumerable<string> GetUsersInRole(string providerName, string roleName) => default;
        public virtual bool IsSupported(ProviderActions action) => default;
        public abstract void RemoveUserFromRole(string userName, string roleName);
        public abstract void RemoveUserFromRoles(string username, IEnumerable<string> roleNames);
        public abstract void RemoveUsersFromRoles(IEnumerable<string> usernames, IEnumerable<string> roleNames);
        public virtual void RemoveUsersFromRoles(string providerName, IEnumerable<string> usernames, IEnumerable<string> roleNames) { }
        public abstract bool RoleExists(string roleName);
    }
}
