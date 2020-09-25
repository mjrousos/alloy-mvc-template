using System.Globalization;

namespace EPiServer.Globalization
{
    public abstract class LanguageSelection
    {
        public abstract CultureInfo FinalFallbackCulture { get; }
    }
}
