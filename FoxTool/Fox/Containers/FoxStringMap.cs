using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace FoxTool.Fox.Containers
{
    internal class FoxStringMap<T> : IFoxStringMap<T> where T : IFoxValue, new()
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
                // TODO: Refactor this. It's copied all over the containers.
                T value = new T();
                value.Read(input);
                input.AlignRead(16);
                _map.Add(key, value);
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

        public void Accept(FoxContainerVisitor visitor)
        {
            visitor.Visit((IFoxStringMap<IFoxValue>) this);
        }

        public int Count()
        {
            return _map.Count;
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
                    pair.Value.WriteXmlAttributes(writer);
                    writer.WriteEndElement();

                }
            }
        }

        public IEnumerator<IFoxKeyValuePair<FoxName, T>> GetEnumerator()
        {
            var newPairs = _map.Select(pair => new FoxKeyValuePair<FoxName, T>(pair.Key, pair.Value))
                .Cast<IFoxKeyValuePair<FoxName, T>>()
                .ToList();
            return newPairs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
