using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxEntityPtr : FoxValue
    {
        public ulong EntityPtr { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            EntityPtr = reader.ReadUInt64();
        }

        public override void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(EntityPtr);
        }

        public override int Size()
        {
            return sizeof (ulong);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override string ToString()
        {
            return string.Format("0x{0:X8}", EntityPtr);
        }
    }
}
