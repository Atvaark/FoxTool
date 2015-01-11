using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FoxTool.Fox
{
    public abstract class FoxValue : IFoxValue
    {
        public abstract void Read(Stream input);

        public void WriteXmlElement(XmlWriter writer)
        {
            writer.WriteStartElement("value");
            WriteXmlAttributes(writer);
            writer.WriteEndElement();
        }

        public void WriteXmlAttributes(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }
        public abstract int Size();
        public abstract void ResolveNames(Dictionary<ulong, string> nameMap);
    }
}
