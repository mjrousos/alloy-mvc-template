using EPiServer.Core;

namespace EPiServer.Web.Mvc
{
    public abstract class BlockController<TBlockData> : PartialContentController<TBlockData>, IRenderTemplate<TBlockData>, IRenderTemplate where TBlockData : BlockData
    {
    }
}
