using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GlobalCameraSettings
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat FocalDistance { get; set; }
        public FoxFloat FocalLength { get; set; }
        public FoxFloat Aperture { get; set; }
        public FoxFloat ShutterSpeed { get; set; }
        public FoxUInt32 Flags { get; set; }
    }
}
