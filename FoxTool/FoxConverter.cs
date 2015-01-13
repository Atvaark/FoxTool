using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using FoxTool.Fox;

namespace FoxTool
{
    internal static class FoxConverter
    {
        public static void DecompileFox(FoxFile foxFile, Stream output)
        {
            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true
            };

            XmlWriter writer = XmlWriter.Create(output, settings);
            XmlSerializer serializer = new XmlSerializer(typeof (FoxFile));
            serializer.Serialize(writer, foxFile);
            writer.Close();
        }

        public static FoxFile CompileFox(Stream input)
        {
            var foxFile = ReadFoxFile(input);
            return foxFile;
        }

        private static FoxFile ReadFoxFile(Stream input)
        {
            var xmlReaderSettings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true
            };
            XmlReader reader = XmlReader.Create(input, xmlReaderSettings);
            XmlSerializer serializer = new XmlSerializer(typeof (FoxFile));
            var foxFile = (FoxFile) serializer.Deserialize(reader);
            return foxFile;
        }
    }
}
