using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class AmbientOcclusionSettings
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxInt32 Method { get; set; }
        public FoxInt32 Attachment { get; set; }
        // name=lineSSAOParameters
        public FoxEntityPtr LineSsaoParameters { get; set; }
        // name=areaSSAOParameters
        public FoxEntityPtr AreaSsaoParameters { get; set; }
    }
}
