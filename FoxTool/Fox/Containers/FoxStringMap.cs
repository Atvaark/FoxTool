using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Containers
{
    public class FoxStringMap<T> : IFoxContainer where T : IFoxValue, new()
    {
        private readonly Dictionary<FoxName, T> _map;

        public FoxStringMap()
        {
            _map = new Dictionary<FoxName, T>();
        }

        public void Read(Stream input, short valueCount)
        {
            for (int i = 0; i < valueCount; i++)
            {
                FoxHash hash = FoxHash.ReadFoxHash(input);
                FoxName key = new FoxName
                {
                    Hash = hash
                };
                T value = new T();
                value.Read(input);
                input.AlignRead(16);
                _map.Add(key, value);
            }
        }

        public void Write(Stream output)
        {
            foreach (var pair in _map)
            {
                pair.Key.Hash.Write(output);
                pair.Value.Write(output);
                output.AlignWrite(16, 0x00);
            }
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            foreach (var pair in _map)
            {
                pair.Key.Resolve(nameMap);
                pair.Value.ResolveNames(nameMap);
            }
        }

        public int Count()
        {
            return _map.Count;
        }

        public void CalculateHashes()
        {
            foreach (var pair in _map)
            {
                pair.Key.CalculateHash();
                pair.Value.CalculateHashes();
            }
        }

        public void CollectNames(List<FoxName> names)
        {
            foreach (var pair in _map)
            {
                names.Add(pair.Key);
                pair.Value.CollectNames(names);
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            while (reader.LocalName == "value")
            {
                FoxName key = new FoxName();
                T value = new T();
                key.Name = reader.GetAttribute("key");
                value.ReadXml(reader);
                _map.Add(key, value);
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (_map.Any())
            {
                writer.WriteAttributeString("arraySize", _map.Count().ToString());
                foreach (var pair in _map)
                {
                    writer.WriteStartElement("value");
                    writer.WriteAttributeString("key",
                        pair.Key.Name ?? String.Format("0x{0:X8}", pair.Key.Hash.HashValue));
                    pair.Value.WriteXml(writer);
                    writer.WriteEndElement();
                }
            }
        }
    }
}
