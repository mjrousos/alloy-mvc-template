using EPiServer.Core;

namespace EPiServer.Filters
{
    public class FilterSort : PageFilterBase, IPageFilter, IContentFilter
    {
        public FilterSort(FilterSortOrder sortOrder) { }

        public void Sort(PageDataCollection pages) { }
    }
}
