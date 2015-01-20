using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types.Values
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

        public void CalculateHashes()
        {
            FileNameHash = FileName == null ? FileNameHash : new FoxHash { HashValue = Hashing.HashString(FileName) };
        }

        public void CollectNames(List<FoxName> names)
        {
            names.Add(new FoxName(FileName, FileNameHash));
        }

        public void ReadXml(XmlReader reader)
        {
            var isEmptyElement = reader.IsEmptyElement;
            // TODO: Call ReadXml on FileNameHash
            string hash = reader.GetAttribute("hash");
            if (hash != null)
            {
                FileNameHash = new FoxHash();
                FileNameHash.HashValue = hash.StartsWith("0x")
                    ? ulong.Parse(hash.Substring(2, hash.Length - 2), NumberStyles.AllowHexSpecifier)
                    : ulong.Parse(hash);
            }

            reader.ReadStartElement("value");
            if (isEmptyElement == false)
            {
                FileName = reader.ReadContentAsString();
                reader.ReadEndElement();
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            if (FileName == null)
                FileNameHash.WriteXml(writer);
            else
                writer.WriteString(FileName);
        }

        public override string ToString()
        {
            return FileName ?? String.Format("0x{0:X8}", FileNameHash.HashValue);
        }
    }
}
