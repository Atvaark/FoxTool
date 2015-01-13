﻿using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace FoxTool.Fox.Types.Structs
{
    public class FoxColor : FoxStruct
    {
        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }
        public float Alpha { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Red = reader.ReadSingle();
            Green = reader.ReadSingle();
            Blue = reader.ReadSingle();
            Alpha = reader.ReadSingle();
        }

        public override void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(Red);
            writer.Write(Green);
            writer.Write(Blue);
            writer.Write(Alpha);
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
            Red = float.Parse(reader.GetAttribute("r"), CultureInfo.InvariantCulture);
            Green = float.Parse(reader.GetAttribute("g"), CultureInfo.InvariantCulture);
            Blue = float.Parse(reader.GetAttribute("b"), CultureInfo.InvariantCulture);
            Alpha = float.Parse(reader.GetAttribute("a"), CultureInfo.InvariantCulture);
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
                reader.ReadEndElement();
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("r", Red.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("g", Green.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("b", Blue.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("a", Alpha.ToString("N6", CultureInfo.InvariantCulture));
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "r={0:N6}, g={1:N6}, b={2:N6}, a={3:N6}", Red, Green,
                Blue, Alpha);
        }
    }
}
