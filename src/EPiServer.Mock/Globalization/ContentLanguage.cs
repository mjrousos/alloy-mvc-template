using System.Globalization;

namespace EPiServer.Globalization
{
    public class ContentLanguage : LanguageSelection
    {
        public override CultureInfo FinalFallbackCulture { get; }

        public static ContentLanguage Instance { get; set; }

        public static CultureInfo PreferredCulture { get; set; }

        public static CultureInfo SpecificCulture { get; }
    }
}
