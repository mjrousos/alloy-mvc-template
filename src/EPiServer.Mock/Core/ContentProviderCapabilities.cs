using System;

namespace EPiServer.Core
{
    [Flags]
    public enum ContentProviderCapabilities
    {
        Copy,
        Create,
        Delete,
        Edit,
        Move,
        MultiLanguage,
        None,
        PageFolder,
        Search,
        Security,
        Wastebasket
    }
}
