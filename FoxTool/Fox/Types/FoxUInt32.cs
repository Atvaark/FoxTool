﻿using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxUInt32 : FoxValue
    {
        public uint Value { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Value = reader.ReadUInt32();
        }


        public override int Size()
        {
            return sizeof (uint);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
