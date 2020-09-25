using System.Collections.Generic;

namespace EPiServer.Shell.ObjectEditing
{
    public interface ISelectionFactory
    {
        IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata);
    }
}
