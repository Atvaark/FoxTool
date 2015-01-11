using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppHumanEnemyRealizerConfigulation
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat RealizeRange { get; set; }
        public FoxFloat UnrealizeRange { get; set; }
        public FoxUInt8 PriorityUnitSize { get; set; }
        public FoxUInt8 FramePerCycleMin { get; set; }
        public FoxUInt8 FramePerCycleMax { get; set; }
    }
}
