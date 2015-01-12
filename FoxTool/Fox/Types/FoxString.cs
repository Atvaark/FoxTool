using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types
{
    public class FoxString : IFoxValue
    {
        public FoxHash StringHash { get; set; }
        public string String { get; set; }

        public void Read(Stream input)
        {
            StringHash = FoxHash.ReadFoxHash(input);
        }

        public void Write(Stream output)
        {
            StringHash.Write(output);
        }

        public int Size()
        {
            return FoxHash.Size;
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(StringHash.HashValue, out name);
            String = name;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String ?? String.Format("0x{0:X8}", StringHash.HashValue);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
        }
    }
}
