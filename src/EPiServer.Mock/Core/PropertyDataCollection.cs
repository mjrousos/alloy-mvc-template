using System;
using System.Collections;
using System.Collections.Generic;

namespace EPiServer.Core
{
    public class PropertyDataCollection : ICollection<PropertyData>, IEnumerable<PropertyData>, IEnumerable
    {
        public virtual PropertyData this[int index]
        {
            get => default;
            set { }
        }

        public virtual PropertyData this[string name]
        {
            get => default;
            set { }
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(PropertyData item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(PropertyData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(PropertyData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(PropertyData item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<PropertyData> IEnumerable<PropertyData>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
