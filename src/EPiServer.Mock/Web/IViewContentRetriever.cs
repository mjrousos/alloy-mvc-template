using EPiServer.Core;
using System.Globalization;

namespace EPiServer.Web
{
    public interface IViewContentRetriever
    {
        PageData GetPage(PageReference pageLink, CultureInfo culture);
    }
}
