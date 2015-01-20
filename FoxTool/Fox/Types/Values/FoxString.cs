using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types.Values
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

        public void CalculateHashes()
        {
            StringHash = String == null ? StringHash : new FoxHash {HashValue = Hashing.HashString(String)};
        }

        public void CollectNames(List<FoxName> names)
        {
            names.Add(new FoxName(String, StringHash));
        }

        public void ReadXml(XmlReader reader)
        {
            var isEmptyElement = reader.IsEmptyElement;
            StringHash = new FoxHash();
            StringHash.ReadXml(reader);
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
            {
                String = reader.ReadContentAsString();
                reader.ReadEndElement();
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            if (String == null)
                StringHash.WriteXml(writer);
            else
                writer.WriteString(String);
        }

        public override string ToString()
        {
            return String ?? String.Format("0x{0:X8}", StringHash.HashValue);
        }
    }
}
