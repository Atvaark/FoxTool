using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace FoxTool.Fox.Types
{
    public class FoxEntityHandle : IFoxValue
    {
        public ulong Handle { get; set; }

        public void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Handle = reader.ReadUInt64();
        }

        public void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(Handle);
        }

        public int Size()
        {
            return sizeof (ulong);
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
            return string.Format("0x{0:X8}", Handle);
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
