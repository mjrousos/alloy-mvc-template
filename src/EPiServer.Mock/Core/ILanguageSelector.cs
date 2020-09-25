using System.Globalization;

namespace EPiServer.Core
{
    public interface ILanguageSelector
    {
        CultureInfo Language { get; }
    }
}
