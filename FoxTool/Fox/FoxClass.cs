namespace FoxTool.Fox
{
    internal class FoxClass
    {
        public string Name { get; set; }
        public string Super { get; set; }
        public string TestUnknown { get; set; }
        public string Version { get; set; }

        protected bool Equals(FoxClass other)
        {
            return string.Equals(Name, other.Name) && string.Equals(Super, other.Super) &&
                   string.Equals(TestUnknown, other.TestUnknown);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((FoxClass) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Super != null ? Super.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (TestUnknown != null ? TestUnknown.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
