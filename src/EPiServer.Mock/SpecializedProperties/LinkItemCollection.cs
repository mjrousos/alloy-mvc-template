using System;
using System.Collections;
using System.Collections.Generic;

namespace EPiServer.SpecializedProperties
{
    public class LinkItemCollection : IList<LinkItem>, ICollection<LinkItem>, IEnumerable<LinkItem>, IEnumerable, ICloneable
    {
        public LinkItem this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(LinkItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool Contains(LinkItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(LinkItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<LinkItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(LinkItem item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, LinkItem item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(LinkItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
