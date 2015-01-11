using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppLensFlareMaterial : Data
    {
        // Static properties
        public FoxPath Texture { get; set; }
        public FoxEntityLink ArcAlphaField { get; set; }
        public FoxFloat ArcAlphaFadeAngle { get; set; }
        public FoxFloat ArcAlphaBaseAngle { get; set; }
        public FoxEntityLink MaskShape { get; set; }
        public FoxBool DebugDrawMaskShape { get; set; }
    }
}
