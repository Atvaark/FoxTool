using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    internal class FoxProperty
    {
        private const int HeaderSize = 32;
        public FoxDataType DataType { get; set; }
        public FoxContainerType ContainerType { get; set; }
        public ulong NameHash { get; set; }
        public string Name { get; set; }
        public IFoxContainer Container { get; set; }
        // TODO: Find which of the values in Read() is the enum type.
        public string EnumName { get; set; }

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
