using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxString : FoxValue
    {
        public FoxHash Hash { get; set; }
        public string Data { get; set; }

        public override void Read(Stream input)
        {
            Hash = FoxHash.ReadFoxHash(input);
        }


        public override int Size()
        {
            return FoxHash.Size;
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(Hash.HashValue, out name);
            Data = name;
        }

        public override string ToString()
        {
            return Data ?? String.Format("0x{0:X8}", Hash.HashValue);
        }
    }
}
