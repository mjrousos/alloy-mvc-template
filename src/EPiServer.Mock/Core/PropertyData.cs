namespace EPiServer.Core
{
    public abstract class PropertyData
    {
        public abstract object Value { get; set; }

        public virtual object SaveData(PropertyDataCollection properties) => default;
    }
}
