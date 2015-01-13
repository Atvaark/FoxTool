using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace FoxTool.Fox.Types.Structs
{
    public class FoxEntityLink : FoxStruct
    {
        public FoxHash PackagePathHash { get; set; }
        public FoxHash ArchivePathHash { get; set; }
        public FoxHash NameInArchiveHash { get; set; }
        public ulong EntityHandle { get; set; }
        public string PackagePath { get; set; }
        public string ArchivePath { get; set; }
        public string NameInArchive { get; set; }

        public override void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            PackagePathHash = FoxHash.ReadFoxHash(input);
            ArchivePathHash = FoxHash.ReadFoxHash(input);
            NameInArchiveHash = FoxHash.ReadFoxHash(input);
            EntityHandle = reader.ReadUInt64();
        }

        public override void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);
            PackagePathHash.Write(output);
            ArchivePathHash.Write(output);
            NameInArchiveHash.Write(output);
            writer.Write(EntityHandle);
        }

        public override int Size()
        {
            return 3*FoxHash.Size + sizeof (ulong);
        }

        public override void ResolveNames(Dictionary<ulong, string> nameMap)
        {
            PackagePath = ResolveName(nameMap, PackagePathHash.HashValue);
            ArchivePath = ResolveName(nameMap, ArchivePathHash.HashValue);
            NameInArchive = ResolveName(nameMap, NameInArchiveHash.HashValue);
        }

        public override void ReadXml(XmlReader reader)
        {
            var isEmptyElement = reader.IsEmptyElement;
            PackagePath = reader.GetAttribute("packagePath");
            ArchivePath = reader.GetAttribute("archivePath");
            NameInArchive = reader.GetAttribute("nameInArchive");
            reader.ReadStartElement("value");
            if (isEmptyElement == false)
            {
                string value = reader.ReadString();
                EntityHandle = value.StartsWith("0x")
                    ? ulong.Parse(value.Substring(2, value.Length - 2), NumberStyles.AllowHexSpecifier)
                    : ulong.Parse(value);
                reader.ReadEndElement();
            }
        }

        public override void WriteXml(XmlWriter writer)
        {
            // HACK: HashName should should only be set once. Either in ReadFoxHash or the constructor of FoxHash.
            PackagePathHash.HashName = "packagePathHash";
            ArchivePathHash.HashName = "archivePathHash";
            NameInArchiveHash.HashName = "nameInArchiveHash";


            if (String.IsNullOrEmpty(PackagePath))
                PackagePathHash.WriteXml(writer);
            writer.WriteAttributeString("packagePath", PackagePath);
            if (String.IsNullOrEmpty(ArchivePath))
                ArchivePathHash.WriteXml(writer);
            writer.WriteAttributeString("archivePath", ArchivePath);
            if (String.IsNullOrEmpty(NameInArchive))
                NameInArchiveHash.WriteXml(writer);
            writer.WriteAttributeString("nameInArchive", NameInArchive);
            writer.WriteString(String.Format("0x{0:X8}", EntityHandle));
        }

        private string ResolveName(Dictionary<ulong, string> nameMap, ulong hashValue)
        {
            string name;
            nameMap.TryGetValue(hashValue, out name);
            return name;
        }

        public override string ToString()
        {
            string packagePath = PackagePath ?? String.Format("0x{0:X8}", PackagePathHash.HashValue);
            string archivePath = ArchivePath ?? String.Format("0x{0:X8}", ArchivePathHash.HashValue);
            string nameInArchive = NameInArchive ?? String.Format("0x{0:X8}", NameInArchiveHash.HashValue);
            return
                string.Format(
                    "packagePath=\"{0}\", archivePath=\"{1}\", nameInArchive=\"{2}\", EntityHandle=\"0x{3:X8}\"",
                    packagePath, archivePath, nameInArchive, EntityHandle);
        }
    }
}
