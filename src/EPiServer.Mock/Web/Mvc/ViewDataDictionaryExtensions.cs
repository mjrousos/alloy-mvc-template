using EPiServer.Core;
using System.Web.Mvc;

namespace EPiServer.Web.Mvc
{
    public static class ViewDataDictionaryExtensions
    {
        public static EditHintCollection<TViewModel, TContentData> GetEditHints<TViewModel, TContentData>(this ViewDataDictionary viewData)
            where TContentData : IContentData => default;
    }
}
