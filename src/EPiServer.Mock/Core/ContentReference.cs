namespace EPiServer.Core
{
    public class ContentReference
    {
        public static PageReference RootPage { get; set; }

        public static PageReference StartPage { get; set; }

        public virtual int CompareTo(object x) => default;

        public virtual bool CompareToIgnoreWorkID(ContentReference contentReference) => default;

        public static bool IsNullOrEmpty(ContentReference contentLink) => default;
    }
}
