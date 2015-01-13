using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FoxTool.Fox
{
    [XmlRoot("fox")]
    public class FoxFile : IXmlSerializable
    {
        private const int HeaderSize = 32;
        private const uint MagicNumber1 = 0x786f62f2;
        private const uint MagicNumber2 = 0x35;
        private readonly List<FoxClass> _classes;
        private readonly List<FoxEntity> _entities;
        private readonly List<FoxName> _names;
        private string _fileVersion = "0";
        private string _formatVersion = "2";
        private DateTime _originalVersion = DateTime.Now;

        public FoxFile()
        {
            _classes = new List<FoxClass>();
            _entities = new List<FoxEntity>();
            _names = new List<FoxName>();
        }

        public List<FoxClass> Classes
        {
            get { return _classes; }
        }

        public IEnumerable<FoxEntity> Entities
        {
            get { return _entities; }
        }

        public IEnumerable<FoxName> Names
        {
            get { return _names; }
        }

        public string FormatVersion
        {
            get { return _formatVersion; }
            set { _formatVersion = value; }
        }

        public string FileVersion
        {
            get { return _fileVersion; }
            set { _fileVersion = value; }
        }

        public DateTime OriginalVersion
        {
            get { return _originalVersion; }
            set { _originalVersion = value; }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            FormatVersion = reader.GetAttribute("formatVersion");
            FileVersion = reader.GetAttribute("fileVersion");
            DateTime originalVersion;
            DateTime.TryParseExact(reader.GetAttribute("originalVersion"), "ddd MMM dd HH:mm:ss UTCzzz yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out originalVersion);
            OriginalVersion = originalVersion;

            bool isEmptyElement = reader.IsEmptyElement;
            reader.ReadStartElement("fox");
            if (isEmptyElement) return;

            bool isClassesElementEmpty = reader.IsEmptyElement;
            reader.ReadStartElement("classes");
            if (isClassesElementEmpty == false)
            {
                while (reader.LocalName == "class")
                {
                    FoxClass foxClass = new FoxClass();
                    foxClass.ReadXml(reader);
                    _classes.Add(foxClass);
                }
                reader.ReadEndElement();
            }

            bool isEntitiesElementEmpty = reader.IsEmptyElement;
            reader.ReadStartElement("entities");
            if (isEntitiesElementEmpty == false)
            {
                while (reader.LocalName == "entity")
                {
                    FoxEntity foxEntity = new FoxEntity();
                    foxEntity.ReadXml(reader);
                    _entities.Add(foxEntity);
                }
                reader.ReadEndElement();
            }

            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("formatVersion", FormatVersion);
            writer.WriteAttributeString("fileVersion", FileVersion);
            writer.WriteAttributeString("originalVersion",
                String.Format(CultureInfo.InvariantCulture, "{0:ddd MMM dd HH:mm:ss UTCzzz yyyy}", OriginalVersion));
            writer.WriteStartElement("classes");
            foreach (var foxClass in Classes)
            {
                writer.WriteStartElement("class");
                foxClass.WriteXml(writer);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.WriteStartElement("entities");
            foreach (var foxEntity in Entities)
            {
                writer.WriteStartElement("entity");
                foxEntity.WriteXml(writer);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        public static FoxFile ReadFoxFile(Stream input, Dictionary<ulong, string> hashNameDictionary)
        {
            FoxFile foxFile = new FoxFile();
            foxFile.Read(input);
            foxFile.ResolveNames(hashNameDictionary);
            foxFile.GenerateClasses();
            return foxFile;
        }

        private void GenerateClasses()
        {
            FoxClass entityClass = new FoxClass
            {
                Name = "Entity",
                Super = "",
                Version = "2",
                TestUnknown = ""
            };
            _classes.Add(entityClass);

            FoxClass dataClass = new FoxClass
            {
                Name = "Data",
                Super = "Entity",
                Version = "2"
            };
            _classes.Add(dataClass);

            foreach (var entity in Entities)
            {
                FoxClass foxClass = new FoxClass
                {
                    Name = entity.ClassName,
                    Version = entity.Version.ToString(),
                    TestUnknown = entity.SuperClassId.ToString()
                };

                if (_classes.Contains(foxClass) == false)
                    _classes.Add(foxClass);
            }
        }

        private void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            uint magicNumber1 = reader.ReadUInt32();
            uint magicNumber2 = reader.ReadUInt32();
            int entityCount = reader.ReadInt32();
            int stringTableOffset = reader.ReadInt32();
            int offsetData = reader.ReadInt32();
            reader.Skip(12);
            for (int i = 0; i < entityCount; i++)
            {
                FoxEntity entity = FoxEntity.ReadFoxEntity(input);
                _entities.Add(entity);
            }

            FoxName name;
            while ((name = FoxName.ReadFoxHashMapEntry(input)) != null)
            {
                _names.Add(name);
            }
            input.AlignRead(16);
            reader.Skip(2);
            string eof = reader.ReadString(3);
            input.AlignRead(16);

            // TODO: Read enums
        }

        private void ResolveNames(Dictionary<ulong, string> hashNameDictionary)
        {
            var nameMap = GenerateNameMap(hashNameDictionary);
            foreach (var entity in _entities)
            {
                entity.ResolveNames(nameMap);
            }
        }

        private Dictionary<ulong, string> GenerateNameMap(Dictionary<ulong, string> hashNameDictionary)
        {
            Dictionary<ulong, string> nameMap = new Dictionary<ulong, string>(hashNameDictionary);
            foreach (var name in _names)
            {
                if (nameMap.ContainsKey(name.Hash.HashValue) == false)
                {
                    // TODO: What should be done with hashed names that look like: /as/XXXXXX.ftex
                    if (name.Name.IsPrintable())
                        nameMap.Add(name.Hash.HashValue, name.Name);
                }
            }
            return nameMap;
        }

        public void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            long headerPosition = output.Position;
            output.Position += HeaderSize;
            foreach (var foxEntity in Entities)
            {
                foxEntity.Write(output);
            }
            int offsetHashMap = (int) output.Position;
            foreach (var foxName in Names)
            {
                foxName.Write(output);
            }

            output.AlignWrite(16, 0x00);
            writer.Write(new byte[] {0x00, 0x00, 0x65, 0x6E, 0x64});
            output.AlignWrite(16, 0x00);

            long endPosition = output.Position;
            output.Position = headerPosition;
            int entityCount = Entities.Count();
            writer.Write(MagicNumber1);
            writer.Write(MagicNumber2);
            writer.Write(entityCount);
            writer.Write(offsetHashMap);
            writer.Write(HeaderSize);
            writer.WriteZeros(12);
            output.Position = endPosition;
        }

        public void CalculateHashes()
        {
            foreach (var foxEntity in Entities)
            {
                foxEntity.CalculateHashes();
            }
        }

        public void CollectNames()
        {
            List<FoxName> names = new List<FoxName>();
            foreach (var foxEntity in Entities)
            {
                foxEntity.CollectNames(names);
            }
            _names.AddRange(names.Distinct());
        }
    }
}
