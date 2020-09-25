using System;

namespace EPiServer.Shell.Security
{
    public abstract class UISignInManager : IDisposable
    {
        public void Dispose() { }

        public virtual bool SignIn(string providerName, string username, string password) => default;

        public virtual void SignOut() { }
    }
}
