using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace EPiServer.Shell.ObjectEditing
{
    public sealed class DefaultDragAndDropTargetAttribute : Attribute, _Attribute, IMetadataAware
    {
        public DefaultDragAndDropTargetAttribute() { }
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            throw new NotImplementedException();
        }
    }
}
