using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using FoxTool.Fox;

namespace FoxTool
{
    internal static class FoxConverter
    {
        public static void ConvertToFox(FoxFile foxFile, Stream output)
        {
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true
            };

            XmlWriter writer = XmlWriter.Create(output, settings);

            writer.WriteStartElement("fox");
            writer.WriteAttributeString("formatVersion", "2");
            writer.WriteAttributeString("fileVersion", "0");
            writer.WriteAttributeString("originalVersion",
                String.Format(CultureInfo.InvariantCulture, "{0:ddd MMM dd HH:mm:ss UTCzzz yyyy}", DateTime.Now));

            writer.WriteStartElement("classes");
            foreach (var foxClass in foxFile.Classes)
            {
                writer.WriteStartElement("class");
                writer.WriteAttributeString("name", foxClass.Name);
                writer.WriteAttributeString("super", foxClass.Super);
                writer.WriteAttributeString("version", foxClass.Version);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteStartElement("entities");
            foreach (var foxEntity in foxFile.Entities)
            {
                writer.WriteStartElement("entity");
                writer.WriteAttributeString("class", foxEntity.ClassName);
                writer.WriteAttributeString("addr", String.Format("0x{0:X8}", foxEntity.Address));
                // TODO: Add Entity id attribute
                //writer.WriteAttributeString("id", ""); 

                writer.WriteStartElement("staticProperties");
                WriteFoxProperties(writer, foxEntity.StaticProperties);
                writer.WriteEndElement();

                writer.WriteStartElement("dynamicProperties");
                WriteFoxProperties(writer, foxEntity.DynamicProperties);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //writer.WriteStartElement("enums");
            // TODO: Add FoxFile enums list
            //writer.WriteEndElement();


            writer.WriteEndElement();
            writer.Close();
        }

        private static void WriteFoxProperties(XmlWriter writer, IEnumerable<FoxProperty> properties)
        {
            foreach (var property in properties)
            {
                writer.WriteStartElement("property");
                writer.WriteAttributeString("name", property.Name);
                writer.WriteAttributeString("type", property.DataType.ToXmlName());
                writer.WriteAttributeString("container", property.ContainerType.ToString());
                property.Container.WriteXml(writer);
                writer.WriteEndElement();
            }
        }
    }
}
