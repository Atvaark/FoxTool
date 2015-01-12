using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FoxTool.Fox
{
    public interface IFoxValue : IXmlSerializable
    {
        void Read(Stream input);
        void Write(Stream output);
        int Size();
        void ResolveNames(Dictionary<ulong, string> nameMap);
    }
}
