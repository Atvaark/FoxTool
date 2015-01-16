using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class SoundDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr SoundFile { get; set; }
    }
}