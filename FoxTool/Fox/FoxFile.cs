using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    internal class FoxFile
    {
        private readonly List<FoxClass> _classes;
        private readonly List<FoxEntity> _entities;
        private readonly List<FoxName> _names;

        public FoxFile()
        {
            _classes = new List<FoxClass>();
            _entities = new List<FoxEntity>();
            _names = new List<FoxName>();
        }

        public IEnumerable<FoxClass> Classes
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
    }
}
