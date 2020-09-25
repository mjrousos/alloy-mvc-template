using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.Shell.Security
{
    public abstract class UIUserProvider : IDisposable
    {
        public abstract bool Enabled { get; }
        public virtual bool EnablePasswordReset { get; }
        public virtual int MinRequiredNonAlphanumericCharacters { get; }
        public virtual int MinRequiredPasswordLength { get; }
        public abstract string Name { get; }
        public virtual bool RequiresQuestionAndAnswer { get; }
        public virtual bool RequiresUniqueEmail { get; }
        public abstract IUIUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, out UIUserCreateStatus status, out IEnumerable<string> errors);
        public abstract bool DeleteUser(string username, bool deleteAllRelatedData);
        public virtual bool DeleteUser(string providerName, string username, bool deleteAllRelatedData) => default;
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract IEnumerable<IUIUser> FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
        public abstract IEnumerable<IUIUser> FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords);
        public abstract IEnumerable<IUIUser> GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
        public abstract IUIUser GetUser(string username);
    }
}
