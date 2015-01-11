using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SimEngineOnPhysicsParam
    {
        // Static properties
        public FoxBool IsEnableGeoCheck { get; set; }
        public FoxBool ConvertMoveToWind { get; set; }
        public FoxInt32 MinLodLevel { get; set; }
        public FoxInt32 MaxLodLevel { get; set; }
    }
}
