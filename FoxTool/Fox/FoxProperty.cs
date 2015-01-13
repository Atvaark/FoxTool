using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FoxTool.Fox
{
    public class FoxProperty : IXmlSerializable
    {
        private const int HeaderSize = 32;
        public string Name { get; set; }
        public ulong NameHash { get; set; }
        public FoxDataType DataType { get; set; }
        public FoxContainerType ContainerType { get; set; }
        public IFoxContainer Container { get; set; }
        // TODO: Find which of the values in Read() is the enum type.
        public string EnumName { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Name = reader.GetAttribute("name");
            string dataType = reader.GetAttribute("type");
            DataType = ExtensionMethods.ParseFoxDataType(dataType);
            string containerType = reader.GetAttribute("container");
            ContainerType = ExtensionMethods.ParseFoxContainerType(containerType);
            bool emptyElement = reader.IsEmptyElement;
            reader.ReadStartElement("property");
            Container = FoxContainerFactory.CreateTypedFromTypes(DataType, ContainerType);
            if (emptyElement == false)
            {
                Container.ReadXml(reader);
                reader.ReadEndElement();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("name", Name);
            writer.WriteAttributeString("type", DataType.ToXmlName());
            writer.WriteAttributeString("container", ContainerType.ToString());
            Container.WriteXml(writer);
        }

        public static FoxProperty ReadFoxProperty(Stream input)
        {
            FoxProperty property = new FoxProperty();
            property.Read(input);
            return property;
        }

        private void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            NameHash = reader.ReadUInt64();

            DataType = (FoxDataType) reader.ReadByte();
            ContainerType = (FoxContainerType) reader.ReadByte();
            short valueCount = reader.ReadInt16();
            short offset = reader.ReadInt16();
            ushort size = reader.ReadUInt16();

            int unknown2 = reader.ReadInt32();
            int unknown3 = reader.ReadInt32();
            int unknown4 = reader.ReadInt32();
            int unknown5 = reader.ReadInt32();

            Container = FoxContainerFactory.ReadContainer(input, DataType, ContainerType, valueCount);
            input.AlignRead(16);
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            Name = nameMap[NameHash];
            Container.ResolveNames(nameMap);
        }
    }
}
