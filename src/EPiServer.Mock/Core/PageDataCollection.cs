using System;
using System.Collections;
using System.Collections.Generic;

namespace EPiServer.Core
{
    public class PageDataCollection : IList<PageData>, ICollection<PageData>, IEnumerable<PageData>, IList, ICollection, IEnumerable

    {
        public PageData this[int index] { get => default; set { } }

        object IList.this[int index] { get => default; set { } }

        public int Count => default;

        public bool IsReadOnly => default;

        bool IList.IsFixedSize => default;

        object ICollection.SyncRoot => default;

        bool ICollection.IsSynchronized => default;

        public void Add(PageData item) { }

        public void Clear() { }

        public bool Contains(PageData item) => default;

        public void CopyTo(PageData[] array, int arrayIndex) { }

        public IEnumerator<PageData> GetEnumerator() => default;

        public int IndexOf(PageData item) => default;

        public void Insert(int index, PageData item) { }

        public bool Remove(PageData item) => default;

        public void RemoveAt(int index) { }

        int IList.Add(object value) => default;

        bool IList.Contains(object value) => default;

        void ICollection.CopyTo(Array array, int index) { }

        IEnumerator IEnumerable.GetEnumerator() => default;

        int IList.IndexOf(object value) => default;

        void IList.Insert(int index, object value) { }

        void IList.Remove(object value) { }

        public PageDataCollection(IEnumerable<PageData> collection) { }
    }
}
