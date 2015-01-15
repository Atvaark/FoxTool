using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Containers
{
    public class FoxListBase<T> : IFoxContainer, IEnumerable<T> where T : IFoxValue, new()
    {
        private readonly List<T> _values;

        public FoxListBase()
        {
            _values = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _values).GetEnumerator();
        }

        public void Read(Stream input, short valueCount)
        {
            for (int i = 0; i < valueCount; i++)
            {
                T value = new T();
                value.Read(input);
                _values.Add(value);
            }
        }

        public void Write(Stream output)
        {
            foreach (var value in _values)
            {
                value.Write(output);
            }
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            foreach (var value in _values)
            {
                value.ResolveNames(nameMap);
            }
        }

        public int Count()
        {
            return _values.Count;
        }

        public void CalculateHashes()
        {
            foreach (var value in _values)
            {
                value.CalculateHashes();
            }
        }

        public void CollectNames(List<FoxName> names)
        {
            foreach (var value in _values)
            {
                value.CollectNames(names);
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
                T value = new T();
                value.ReadXml(reader);
                _values.Add(value);
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (_values.Any())
            {
                writer.WriteAttributeString("arraySize", _values.Count().ToString());
                foreach (var value in _values)
                {
                    writer.WriteStartElement("value");
                    value.WriteXml(writer);
                    writer.WriteEndElement();
                }
            }
        }
    }
}
