using EPiServer.DataAbstraction;
using System;

namespace EPiServer.Web.Mvc
{
    public class TemplateModelCollection
    {
        public TemplateModelCollection() { }

        public void Add(Type modelType, TemplateModel viewTemplateModel) { }

        public void Add(Type modelType, params TemplateModel[] viewTemplateModels) { }
    }
}
