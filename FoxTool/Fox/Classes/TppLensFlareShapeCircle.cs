using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppLensFlareShapeCircle : TppLensFlareShape
    {
        // Static properties
        public FoxFloat OuterScale { get; set; }
        public FoxFloat InnerScale { get; set; }
        public FoxUInt32 DivideNum { get; set; }
        public FoxBool DebugDrawPolygon { get; set; }
    }
}
