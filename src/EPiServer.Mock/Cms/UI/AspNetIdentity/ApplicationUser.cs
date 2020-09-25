using Microsoft.AspNet.Identity;

namespace EPiServer.Cms.UI.AspNetIdentity
{
    public class ApplicationUser : IUser<string>
    {
        public string Id { get; }

        public string UserName { get; set; }
    }
}
