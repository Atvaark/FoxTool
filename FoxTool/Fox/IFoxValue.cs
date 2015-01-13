using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FoxTool.Fox
{
    public interface IFoxValue : IXmlSerializable
    {
        void Read(Stream input);
        void Write(Stream output);
        int Size();
        void ResolveNames(Dictionary<ulong, string> nameMap);
        void CalculateHashes();
        void CollectNames(List<FoxName> names);
    }
}
