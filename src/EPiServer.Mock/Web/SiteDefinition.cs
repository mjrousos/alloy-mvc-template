using EPiServer.Core;

namespace EPiServer.Web
{
    public class SiteDefinition
    {
        public SiteDefinition() { }

        public const string SiteAssetsName = "SysSiteAssets";

        public const string WildcardHostName = "*";

        public virtual ContentReference ContentAssetsRoot { get; }

        public static SiteDefinition Current { get; set; }

        public static SiteDefinition Empty { get; }

        public virtual ContentReference GlobalAssetsRoot { get; }

        public virtual ContentReference StartPage { get; set; }
    }
}
