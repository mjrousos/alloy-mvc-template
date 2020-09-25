using System.Collections.Generic;
using System.Globalization;

namespace EPiServer.Framework.Localization
{
    public abstract class LocalizationService
    {
        public static readonly string MissingMessageFormat;
        public abstract IEnumerable<CultureInfo> AvailableLocalizations { get; }
        public static LocalizationService Current { get; }
        public bool TryGetString(string resourceKey, out string localizedString)
        {
            localizedString = default;
            return default;
        }
        public string GetString(string resourceKey) => default;
    }
}
