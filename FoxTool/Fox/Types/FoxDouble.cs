using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace FoxTool.Fox.Types
{
    public class FoxDouble : FoxValue
    {
        public double Value { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Value = reader.ReadDouble();
        }


        public override int Size()
        {
            return sizeof (double);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override string ToString()
        {
            return Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
