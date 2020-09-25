using EPiServer.Framework.Web;

namespace EPiServer.Filters
{
    public class FilterTemplate : PageFilterBase, IPageFilter, IContentFilter
    {
        public TemplateTypeCategories TemplateTypeCategories { get; set; }
    }
}
