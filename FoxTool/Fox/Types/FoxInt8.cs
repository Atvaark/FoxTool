using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types
{
    internal class FoxInt8 : IFoxValue
    {
        public sbyte Value { get; set; }

        public void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Value = reader.ReadSByte();
        }

        public void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(Value);
        }

        public int Size()
        {
            return sizeof (sbyte);
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public void ReadXml(XmlReader reader)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return Value.ToString();
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
