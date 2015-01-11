using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppMissionBlockData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 MissionBlockSize { get; set; }
        public FoxBool Enable { get; set; }
    }
}
