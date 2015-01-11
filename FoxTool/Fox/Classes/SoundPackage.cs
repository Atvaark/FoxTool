using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
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
