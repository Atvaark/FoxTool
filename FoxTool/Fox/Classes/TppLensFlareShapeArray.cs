using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppLensFlareShapeArray : TppLensFlareShape
    {
        // Static properties
        public FoxUInt32 SpriteCount { get; set; }
        public FoxFloat OffsetScaleMin { get; set; }
        public FoxFloat OffsetScaleMax { get; set; }
        public FoxFloat SizeScaleMin { get; set; }
        public FoxFloat SizeScaleMax { get; set; }
        public FoxColor RandomColorMin { get; set; }
        public FoxColor RandomColorMax { get; set; }
        public FoxUInt32 RandomSeed { get; set; }
    }
}
