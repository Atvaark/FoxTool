using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FoxTool.Fox
{
    public abstract class FoxStruct : IFoxValue
    {
        public abstract void Read(Stream input);
        public abstract void Write(Stream output);

        public void WriteXmlElement(XmlWriter writer)
        {
            writer.WriteStartElement("value");
            WriteXmlAttributes(writer);
            writer.WriteEndElement();
        }

        public abstract void WriteXmlAttributes(XmlWriter writer);
        public abstract int Size();
        public abstract void ResolveNames(Dictionary<ulong, string> nameMap);
    }
}
