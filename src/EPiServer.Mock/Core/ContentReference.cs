namespace EPiServer.Core
{
    public class ContentReference
    {
        public virtual int CompareTo(object x) => default;

        public virtual bool CompareToIgnoreWorkID(ContentReference contentReference) => default;
    }
}
