using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FoxTool.Fox
{
    internal interface IFoxContainer
    {
        void Read(Stream input, short valueCount);
        void ResolveNames(Dictionary<ulong, string> nameMap);
        void Accept(FoxContainerVisitor visitor);
        int Count();
        void WriteXml(XmlWriter writer);
    }
}
