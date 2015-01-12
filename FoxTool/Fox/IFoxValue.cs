using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FoxTool.Fox
{
    public interface IFoxValue
    {
        void Read(Stream input);
        void Write(Stream output);
        void WriteXmlElement(XmlWriter writer);
        void WriteXmlAttributes(XmlWriter writer);
        int Size();
        void ResolveNames(Dictionary<ulong, string> nameMap);
    }
}
