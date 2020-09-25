using EPiServer.Core;

namespace EPiServer.Filters
{
    public class FilterPublished : PageFilterBase, IPageFilter, IContentFilter
    {
        public override bool ShouldFilter(IContent content) => default;
        public override bool ShouldFilter(PageData page) => default;
    }
}
