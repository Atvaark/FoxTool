using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxFloat : FoxValue
    {
        public float Value { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Value = reader.ReadSingle();
        }


        public override int Size()
        {
            return sizeof (float);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:N6}", Value);
        }
    }
}
