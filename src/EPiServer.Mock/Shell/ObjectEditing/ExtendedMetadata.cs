using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EPiServer.Shell.ObjectEditing
{
    public class ExtendedMetadata : DataAnnotationsModelMetadata
    {
        public ExtendedMetadata(DataAnnotationsModelMetadataProvider provider, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName, DisplayColumnAttribute displayColumnAttribute) : base(provider, containerType, modelAccessor, modelType, propertyName, displayColumnAttribute) { }
    }
}
