using EPiServer.Core;
using System;
using System.Linq.Expressions;

namespace EPiServer.Web.Mvc
{
    public class EditHintCollection<TViewModel, TContentData> : FullRefreshEditHintCollection<TContentData> where TContentData : IContentData
    {
        public EditHintCollection<TViewModel, TContentData> AddConnection<TResult>(Expression<Func<TViewModel, TResult>> viewModelProperty, Expression<Func<TContentData, TResult>> contentDataProperty) => default;
    }
}
