using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class SoundPackage
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr SoundDataFile { get; set; }
        public FoxBool SyncLoad { get; set; }
    }
}
