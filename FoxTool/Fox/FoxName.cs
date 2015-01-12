using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    public class FoxName
    {
        public FoxHash Hash { get; set; }
        public string Name { get; set; }

        public static FoxName ReadFoxHashMapEntry(Stream input)
        {
            FoxName name = new FoxName();
            name.Read(input);
            return name.Hash.HashValue == 0 ? null : name;
        }

        private void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Hash = FoxHash.ReadFoxHash(input);

            if (Hash.HashValue == 0)
                return;
            int stringLength = reader.ReadInt32();
            Name = reader.ReadString(stringLength);
        }

        public void Resolve(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(Hash.HashValue, out name);
            Name = name;
        }
    }
}
