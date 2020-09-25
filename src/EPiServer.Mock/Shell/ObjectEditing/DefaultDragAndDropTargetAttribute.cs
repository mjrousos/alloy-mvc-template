using System;
using System.Web.Mvc;

namespace EPiServer.Shell.ObjectEditing
{
    public sealed class DefaultDragAndDropTargetAttribute : Attribute, IMetadataAware
    {
        public DefaultDragAndDropTargetAttribute() { }
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            throw new NotImplementedException();
        }
    }
}
