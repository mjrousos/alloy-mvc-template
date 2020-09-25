using System.Collections;
using System.Collections.Generic;

namespace EPiServer
{
    public class PropertyCriteriaCollection : CollectionBase, IList, ICollection, IEnumerable<PropertyCriteria>, IEnumerable
    {
        IEnumerator<PropertyCriteria> IEnumerable<PropertyCriteria>.GetEnumerator() => default;
        public void Add(PropertyCriteria criteria) { }
    }
}
