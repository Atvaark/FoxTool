using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppOutOfMissionRangeEffect
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxBool Enable { get; set; }
        public FoxPath LutTexture { get; set; }
        public FoxFloat StartSlope { get; set; }
        public FoxFloat EndSlope { get; set; }
        public FoxFloat BlendRatio { get; set; }
        public FoxColor ColorScale { get; set; }
        public FoxFloat NoiseScale { get; set; }
        public FoxFloat NoiseOffset { get; set; }
        public FoxFloat NoiseCutScale { get; set; }
        public FoxFloat NoiseCutOffset { get; set; }
        public FoxColor NoiseColor { get; set; }
        public FoxFloat CinemaScopeSlope { get; set; }
        public FoxFloat CinemaScopeShift { get; set; }
    }
}
