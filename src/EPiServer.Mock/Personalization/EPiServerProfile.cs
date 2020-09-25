#if NETFRAMEWORK
using System.Web.Profile;

namespace EPiServer.Personalization
{
    public class EPiServerProfile : ProfileBase
    {
        public EPiServerProfile() { }
        public EPiServerProfile(ProfileBase wrappedProfile) { }
        public string Email { get; set; }
        public static EPiServerProfile Wrap(ProfileBase profile) => default;
    }
}
#endif
