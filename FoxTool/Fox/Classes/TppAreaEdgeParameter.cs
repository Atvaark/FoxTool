using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppAreaEdgeParameter
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxUInt32 FadeTime { get; set; }
        public FoxFloat ConnectedClearObstruction { get; set; }
        public FoxFloat ConnectedClearOcclusion { get; set; }
        public FoxFloat ConnectedBlockedObstruction { get; set; }
        public FoxFloat ConnectedBlockedOcclusion { get; set; }
    }
}
