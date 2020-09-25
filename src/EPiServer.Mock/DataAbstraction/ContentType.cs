using System;

namespace EPiServer.DataAbstraction
{
    public class ContentType : IComparable, IComparable<ContentType>
    {
        public int ID { get; set; }

        public int CompareTo(ContentType other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
