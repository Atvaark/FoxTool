using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace FoxTool.Fox.Types.Structs
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

        public override void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(W);
        }

        public override int Size()
        {
            return 4*sizeof (float);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
        }

        public override void CalculateHashes()
        {
        }

        public override void CollectNames(List<FoxName> names)
        {
        }

        public override void ReadXml(XmlReader reader)
        {
            var isEmptyElement = reader.IsEmptyElement;
            X = float.Parse(reader.GetAttribute("x"), CultureInfo.InvariantCulture);
            Y = float.Parse(reader.GetAttribute("y"), CultureInfo.InvariantCulture);
            Z = float.Parse(reader.GetAttribute("z"), CultureInfo.InvariantCulture);
            W = float.Parse(reader.GetAttribute("w"), CultureInfo.InvariantCulture);
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("x", X.ToString("r", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("y", Y.ToString("r", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("z", Z.ToString("r", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("w", W.ToString("r", CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "x=\"{0:r}\", y=\"{1:r}\", z=\"{2:r}\", w=\"{3:r}\"",
                X, Y, Z, W);
        }
    }
}
