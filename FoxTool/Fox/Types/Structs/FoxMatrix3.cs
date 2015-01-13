using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace FoxTool.Fox.Types.Structs
{
    internal class FoxMatrix3 : FoxStruct
    {
        public float Row1Value1 { get; set; }
        public float Row1Value2 { get; set; }
        public float Row1Value3 { get; set; }
        public float Row2Value1 { get; set; }
        public float Row2Value2 { get; set; }
        public float Row2Value3 { get; set; }
        public float Row3Value1 { get; set; }
        public float Row3Value2 { get; set; }
        public float Row3Value3 { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Row1Value1 = reader.ReadSingle();
            Row1Value2 = reader.ReadSingle();
            Row1Value3 = reader.ReadSingle();
            Row2Value1 = reader.ReadSingle();
            Row2Value2 = reader.ReadSingle();
            Row2Value3 = reader.ReadSingle();
            Row3Value1 = reader.ReadSingle();
            Row3Value2 = reader.ReadSingle();
            Row3Value3 = reader.ReadSingle();
        }

        public override void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            writer.Write(Row1Value1);
            writer.Write(Row1Value2);
            writer.Write(Row1Value3);
            writer.Write(Row2Value1);
            writer.Write(Row2Value2);
            writer.Write(Row2Value3);
            writer.Write(Row3Value1);
            writer.Write(Row3Value2);
            writer.Write(Row3Value3);
        }

        public override int Size()
        {
            return 9*sizeof (float);
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
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
            {
                Row1Value1 = float.Parse(reader.GetAttribute("Column1"), CultureInfo.InvariantCulture);
                Row1Value2 = float.Parse(reader.GetAttribute("Column2"), CultureInfo.InvariantCulture);
                Row1Value3 = float.Parse(reader.GetAttribute("Column3"), CultureInfo.InvariantCulture);
                reader.ReadStartElement("Row1");
                Row2Value1 = float.Parse(reader.GetAttribute("Column1"), CultureInfo.InvariantCulture);
                Row2Value2 = float.Parse(reader.GetAttribute("Column2"), CultureInfo.InvariantCulture);
                Row2Value3 = float.Parse(reader.GetAttribute("Column3"), CultureInfo.InvariantCulture);
                reader.ReadStartElement("Row2");
                Row3Value1 = float.Parse(reader.GetAttribute("Column1"), CultureInfo.InvariantCulture);
                Row3Value2 = float.Parse(reader.GetAttribute("Column2"), CultureInfo.InvariantCulture);
                Row3Value3 = float.Parse(reader.GetAttribute("Column3"), CultureInfo.InvariantCulture);
                reader.ReadStartElement("Row3");
                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Row1");
            writer.WriteAttributeString("Column1", Row1Value1.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column2", Row1Value2.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column3", Row1Value3.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteEndElement();
            writer.WriteStartElement("Row2");
            writer.WriteAttributeString("Column1", Row2Value1.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column2", Row2Value2.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column3", Row2Value3.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteEndElement();
            writer.WriteStartElement("Row3");
            writer.WriteAttributeString("Column1", Row3Value1.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column2", Row3Value2.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteAttributeString("Column3", Row3Value3.ToString("N6", CultureInfo.InvariantCulture));
            writer.WriteEndElement();
        }

        public override string ToString()
        {
            return
                string.Format(
                    "Row1Value1: {0}, Row1Value2: {1}, Row1Value3: {2}, Row2Value1: {3}, Row2Value2: {4}, Row2Value3: {5}, Row3Value1: {6}, Row3Value2: {7}, Row3Value3: {8}",
                    Row1Value1, Row1Value2, Row1Value3, Row2Value1, Row2Value2, Row2Value3, Row3Value1, Row3Value2,
                    Row3Value3);
        }
    }
}
