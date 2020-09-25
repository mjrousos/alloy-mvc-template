using System;
using System.Linq.Expressions;

namespace EPiServer.Core
{
    public static class ContentDataExtensions
    {
        public static TPropertyValue GetPropertyValue<TContentData, TPropertyValue>(this TContentData contentData, Expression<Func<TContentData, TPropertyValue>> expression)
            where TContentData : ContentData => default;

        public static void SetPropertyValue<TContentData, TPropertyValue>(this TContentData contentData, Expression<Func<TContentData, TPropertyValue>> expression, TPropertyValue propertyValue)
            where TContentData : ContentData { }

        public static void SetPropertyValue<TContentData, TPropertyData, TPropertyValue>(this TContentData contentData, Expression<Func<TContentData, TPropertyValue>> expression, Action<TPropertyData> valueAction)
            where TContentData : ContentData where TPropertyData : PropertyData { }
    }
}
