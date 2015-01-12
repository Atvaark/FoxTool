using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types
{
    public class FoxPath : IFoxValue
    {
        public FoxHash PathHash { get; set; }
        public string Path { get; set; }

        public void Read(Stream input)
        {
            PathHash = FoxHash.ReadFoxHash(input);
        }

        public void Write(Stream output)
        {
            PathHash.Write(output);
        }

        public int Size()
        {
            return FoxHash.Size;
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(PathHash.HashValue, out name);
            Path = name;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }

        public override string ToString()
        {
            return Path ?? String.Format("0x{0:X8}", PathHash.HashValue);
        }
    }
}
