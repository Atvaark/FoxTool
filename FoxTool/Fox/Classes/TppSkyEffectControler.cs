using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppSkyEffectControler
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink CameraLight { get; set; }
        public FoxUInt32 Hour { get; set; }
        public FoxUInt32 Minute { get; set; }
        public FoxUInt32 Second { get; set; }
    }
}
