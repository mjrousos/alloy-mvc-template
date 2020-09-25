using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPiServer.Cms.UI.AspNetIdentity
{
    public class ApplicationUserManager<T> : UserManager<T, string>
        where T : class, IUser<string>
    {
        public ApplicationUserManager(IUserStore<T, string> store) : base(store) { }
        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUser user) => Task.FromResult<ClaimsIdentity>(default);
    }
}
