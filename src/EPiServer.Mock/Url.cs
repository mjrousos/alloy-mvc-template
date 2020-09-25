using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EPiServer
{
    public class Url : IXmlSerializable
    {
        public Url(string url) { }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty() => default;
    }
}
