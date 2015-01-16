using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FoxTool.Fox.Containers
{
    public interface IFoxContainer : IXmlSerializable
    {
        void Read(Stream input, short valueCount);
        void Write(Stream output);
        void ResolveNames(Dictionary<ulong, string> nameMap);
        int Count();
        void CalculateHashes();
        void CollectNames(List<FoxName> names);
    }
}
