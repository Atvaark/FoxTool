using System;
using System.Collections.Generic;
using System.IO;

namespace FoxTool.Fox.Types
{
    public class FoxString : FoxValue
    {
        public FoxHash StringHash { get; set; }
        public string String { get; set; }

        public override void Read(Stream input)
        {
            StringHash = FoxHash.ReadFoxHash(input);
        }

        public override void Write(Stream output)
        {
            StringHash.Write(output);
        }

        public override int Size()
        {
            return FoxHash.Size;
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(StringHash.HashValue, out name);
            String = name;
        }

        public override string ToString()
        {
            return String ?? String.Format("0x{0:X8}", StringHash.HashValue);
        }
    }
}
