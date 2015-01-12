using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types
{
    public class FoxFilePtr : IFoxValue
    {
        public FoxHash FileNameHash { get; set; }
        public string FileName { get; set; }

        public void Read(Stream input)
        {
            FileNameHash = FoxHash.ReadFoxHash(input);
        }

        public void Write(Stream output)
        {
            FileNameHash.Write(output);
        }

        public int Size()
        {
            return FoxHash.Size;
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(FileNameHash.HashValue, out name);
            FileName = name;
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
            return FileName ?? String.Format("0x{0:X8}", FileNameHash.HashValue);
        }
    }
}
