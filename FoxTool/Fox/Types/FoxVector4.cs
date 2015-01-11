using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace FoxTool.Fox.Types
{
    public class FoxVector4 : FoxStruct
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();
            W = reader.ReadSingle();
        }


        public override void WriteXmlAttributes(XmlWriter writer)
        {
            writer.WriteAttributeString("x", X.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("y", Y.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("z", Z.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("w", W.ToString("N6", CultureInfo.InvariantCulture));
        }

        public override int Size()
        {
            return 4*sizeof (float);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "x=\"{0:N6}\", y=\"{1:N6}\", z=\"{2:N6}\", w=\"{3:N6}\"",
                X, Y, Z, W);
        }
    }
}
