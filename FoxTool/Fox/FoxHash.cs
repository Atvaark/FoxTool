using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    public class FoxHash
    {
        public const int Size = sizeof (ulong);
        public ulong HashValue { get; set; }

        public static FoxHash ReadFoxHash(Stream input)
        {
            FoxHash foxHash = new FoxHash();
            foxHash.Read(input);
            return foxHash;
        }

        public void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            HashValue = reader.ReadUInt64();
        }

        public void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(HashValue);
        }
    }
}
