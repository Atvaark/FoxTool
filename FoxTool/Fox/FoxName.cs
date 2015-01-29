using System.IO;
using System.Text;

namespace FoxTool.Fox
{
    public class FoxName
    {
        public FoxName()
        {
        }

        public FoxName(string name, FoxHash hash)
        {
            Hash = hash;
            Name = name;
        }

        public FoxHash Hash { get; set; }
        public string Name { get; set; }
        public byte[] EncryptedName { get; set; }

        public bool IsEncrypted
        {
            get { return EncryptedName != null; }
        }

        public static FoxName ReadFoxName(Stream input)
        {
            FoxName name = new FoxName();
            name.Read(input);
            return name.Hash.HashValue == 0 ? null : name;
        }

        private void Read(Stream input)
        {
            BinaryReader reader = new BinaryReader(input, Encoding.Default, true);
            Hash = FoxHash.ReadFoxHash(input);

            if (Hash.HashValue == 0)
                return;
            int stringLength = reader.ReadInt32();
            Name = reader.ReadString(stringLength);
        }

        public void Resolve(FoxNameLookupTable lookupTable)
        {
            Name = lookupTable.Lookup(Hash.HashValue);
        }

        public void Write(Stream output)
        {
            BinaryWriter writer = new BinaryWriter(output, Encoding.Default, true);

            byte[] nameBytes = Name == null ? new byte[0] : Encoding.Default.GetBytes(Name);

            Hash.Write(output);
            writer.Write((uint) nameBytes.Length);
            writer.Write(nameBytes);
        }

        public void CalculateHash()
        {
            ulong hash = Hashing.HashString(Name);
            Hash = new FoxHash {HashValue = hash};
        }

        protected bool Equals(FoxName other)
        {
            return Equals(Hash, other.Hash) && string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((FoxName) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Hash != null ? Hash.GetHashCode() : 0)*397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }

        public void CheckForEncryption()
        {
            if (Hashing.HashString(Name) != Hash.HashValue)
            {
                EncryptedName = Encoding.Default.GetBytes(Name);
            }
        }
    }
}
