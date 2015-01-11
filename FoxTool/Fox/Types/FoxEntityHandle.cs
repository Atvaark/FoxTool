using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxEntityHandle : FoxValue
    {
        public ulong Handle { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Handle = reader.ReadUInt64();
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
            return string.Format("0x{0:X8}", Handle);
        }
    }
}
