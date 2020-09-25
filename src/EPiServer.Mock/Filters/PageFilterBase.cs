using EPiServer.Core;

namespace EPiServer.Filters
{
    public abstract class PageFilterBase : IPageFilter, IContentFilter
    {
        public virtual bool ShouldFilter(IContent content) => default;
        public virtual bool ShouldFilter(PageData page) => default;
    }
}
