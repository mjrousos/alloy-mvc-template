namespace EPiServer.Core
{
    public static class PageCriteriaQueryServiceExtensions
    {
        public static PageDataCollection FindPagesWithCriteria(this IPageCriteriaQueryService queryService, PageReference pageLink, PropertyCriteriaCollection criterias) => default;
        public static PageDataCollection FindPagesWithCriteria(this IPageCriteriaQueryService queryService, PageReference pageLink, PropertyCriteriaCollection criterias, string languageBranch) => default;
        public static PageDataCollection FindPagesWithName(this IPageCriteriaQueryService queryService, PageReference pageLink, string pageName, string languageBranch) => default;
    }
}
