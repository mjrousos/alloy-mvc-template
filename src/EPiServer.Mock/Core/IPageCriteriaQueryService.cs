namespace EPiServer.Core
{
    public interface IPageCriteriaQueryService
    {
        PageDataCollection FindAllPagesWithCriteria(PageReference pageLink, PropertyCriteriaCollection criterias, string languageBranch, ILanguageSelector selector);
        PageDataCollection FindPagesWithCriteria(PageReference pageLink, PropertyCriteriaCollection criterias, string languageBranch, ILanguageSelector selector);
    }
}
