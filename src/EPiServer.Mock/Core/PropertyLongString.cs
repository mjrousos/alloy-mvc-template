using System;

namespace EPiServer.Core
{
    public abstract class PropertyLongString : PropertyData
    {
        public PropertyLongString() { }

        public PropertyLongString(string value) { }

        public virtual int FolderID { get; }

        protected virtual string LongString { get; set; }

        public override object Value { get; set; }

        public abstract Type PropertyValueType { get; }
    }
}
