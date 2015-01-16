using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types.Values
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

        public void CalculateHashes()
        {
            ulong hash = Hashing.HashString(Path);
            PathHash = new FoxHash {HashValue = hash};
        }

        public void CollectNames(List<FoxName> names)
        {
            names.Add(new FoxName(Path, PathHash));
        }

        public void ReadXml(XmlReader reader)
        {
            var isEmptyElement = reader.IsEmptyElement;
            string hash = reader.GetAttribute("hash");
            if (hash != null)
            {
                PathHash = new FoxHash();
                PathHash.HashValue = hash.StartsWith("0x")
                    ? ulong.Parse(hash.Substring(2, hash.Length - 2), NumberStyles.AllowHexSpecifier)
                    : ulong.Parse(hash);
            }
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
            {
                Path = reader.ReadContentAsString();
                reader.ReadEndElement();
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            if (String.IsNullOrEmpty(Path))
                PathHash.WriteXml(writer);
            writer.WriteString(Path);
        }

        public override string ToString()
        {
            return Path ?? String.Format("0x{0:X8}", PathHash.HashValue);
        }
    }
}
