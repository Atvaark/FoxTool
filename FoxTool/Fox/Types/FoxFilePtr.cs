using System;
using System.Collections.Generic;
using System.IO;

namespace FoxTool.Fox.Types
{
    public class FoxFilePtr : FoxValue
    {
        public FoxHash FileNameHash { get; set; }
        public string FileName { get; set; }

        public override void Read(Stream input)
        {
            FileNameHash = FoxHash.ReadFoxHash(input);
        }

        public override void Write(Stream output)
        {
            FileNameHash.Write(output);
        }

        public override int Size()
        {
            return FoxHash.Size;
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            string name;
            nameMap.TryGetValue(FileNameHash.HashValue, out name);
            FileName = name;
        }

        public override string ToString()
        {
            return FileName ?? String.Format("0x{0:X8}", FileNameHash.HashValue);
        }
    }
}
