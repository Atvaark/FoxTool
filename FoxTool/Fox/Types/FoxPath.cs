using System;
using System.Collections.Generic;
using System.IO;

namespace FoxTool.Fox.Types
{
    public class FoxPath : FoxValue
    {
        public FoxHash PathHash { get; set; }
        public string Path { get; set; }

        public override void Read(Stream input)
        {
            PathHash = FoxHash.ReadFoxHash(input);
        }


        public override int Size()
        {
            return FoxHash.Size;
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(PathHash.HashValue, out name);
            Path = name;
        }

        public override string ToString()
        {
            return Path ?? String.Format("0x{0:X8}", PathHash.HashValue);
        }
    }
}
