using Microsoft.Owin.Security.Cookies;
using Owin;

namespace EPiServer.Cms.UI.AspNetIdentity
{
    public static class AppBuilderExtensions
    {
        public static void AddCmsAspNetIdentity<T>(this IAppBuilder appBuilder) { }
        public static void CmsOnCookieApplyRedirect(this IAppBuilder appBuilder, CookieApplyRedirectContext cookieApplyRedirectContext, ApplicationSignInManager<ApplicationUser> signInManager) { }
    }
}
