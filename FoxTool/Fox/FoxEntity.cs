using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    internal class FoxEntity
    {
        private readonly List<FoxProperty> _dynamicProperties;
        private readonly List<FoxProperty> _staticProperties;

        public FoxEntity()
        {
            _staticProperties = new List<FoxProperty>();
            _dynamicProperties = new List<FoxProperty>();
        }

        public ulong ClassNameHash { get; set; }
        public string ClassName { get; set; }
        public byte ClassId { get; set; }
        public short Version { get; set; }
        public byte SuperClassId { get; set; }
        public uint Address { get; set; }

        public IEnumerable<FoxProperty> StaticProperties
        {
            get { return _staticProperties; }
        }

        public IEnumerable<FoxProperty> DynamicProperties
        {
            get { return _dynamicProperties; }
        }

        public static FoxEntity ReadFoxEntity(Stream input)
        {
            FoxEntity entity = new FoxEntity();
            entity.Read(input);
            return entity;
        }

        private void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            short headerSize = reader.ReadInt16();
            ClassId = reader.ReadByte();
            SuperClassId = reader.ReadByte();
            short padding1 = reader.ReadInt16();
            uint magicNumber1 = reader.ReadUInt32();
            Address = reader.ReadUInt32();
            ushort padding2 = reader.ReadUInt16();
            int unknown4 = reader.ReadInt32();
            int unknown5 = reader.ReadInt32();
            int unknown6 = reader.ReadInt16();
            Version = reader.ReadInt16();
            ClassNameHash = reader.ReadUInt64();
            ushort staticPropertyCount = reader.ReadUInt16();
            uint dynamicPropetyCount = reader.ReadUInt16();
            int offset = reader.ReadInt32();
            int size1 = reader.ReadInt32();
            int size2 = reader.ReadInt32(); // size2 >= size1
            input.AlignRead(16);

            for (int i = 0; i < staticPropertyCount; i++)
            {
                FoxProperty property = FoxProperty.ReadFoxProperty(input);
                if (property.Container == null)
                    property.Container = null;
                _staticProperties.Add(property);
            }
            for (int i = 0; i < dynamicPropetyCount; i++)
            {
                FoxProperty property = FoxProperty.ReadFoxProperty(input);
                _dynamicProperties.Add(property);
            }
        }

        public void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            ClassName = nameMap[ClassNameHash];
            foreach (var staticProperty in StaticProperties)
            {
                staticProperty.ResolveNames(nameMap);
            }
            foreach (var dynamicProperty in DynamicProperties)
            {
                dynamicProperty.ResolveNames(nameMap);
            }
        }
    }
}
