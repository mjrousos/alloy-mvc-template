using EPiServer.Core;
using EPiServer.Filters;

namespace EPiServer
{
    public class PropertyCriteria
    {
        public PropertyCriteria() { }
        public CompareCondition Condition { get; set; }

        public bool IsNull { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public PropertyDataType Type { get; set; }
        public string Value { get; set; }
    }
}
