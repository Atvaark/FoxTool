using System;
using System.Collections.Generic;
using System.Globalization;
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
            var isEmptyElement = reader.IsEmptyElement;
            string hash = reader.GetAttribute("hash");
            if (hash != null)
            {
                StringHash = new FoxHash();
                StringHash.HashValue = hash.StartsWith("0x")
                    ? ulong.Parse(hash.Substring(2, hash.Length - 2), NumberStyles.AllowHexSpecifier)
                    : ulong.Parse(hash);
            }
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
            if (String.IsNullOrEmpty(String))
                StringHash.WriteXml(writer);
            writer.WriteString(String);
        }

        public override string ToString()
        {
            return String ?? String.Format("0x{0:X8}", StringHash.HashValue);
        }
    }
}
