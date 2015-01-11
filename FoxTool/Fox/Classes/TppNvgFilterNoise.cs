using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppNvgFilterNoise
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxBool Visibility { get; set; }
        public FoxFloat Scale { get; set; }
        public FoxFloat Offset { get; set; }
        public FoxFloat CutScale { get; set; }
        public FoxFloat CutOffset { get; set; }
        public FoxBool IsForceVisible { get; set; }
        public FoxColor Color { get; set; }
        public FoxFloat RadialSlope { get; set; }
        public FoxFloat RadialShift { get; set; }
    }
}
