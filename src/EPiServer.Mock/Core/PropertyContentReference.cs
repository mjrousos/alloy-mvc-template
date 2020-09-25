namespace EPiServer.Core
{
    public class PropertyContentReference : PropertyData
    {
        public virtual ContentReference ContentLink { get; set; }
        public override object Value { get; set; }
    }
}
