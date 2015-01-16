using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppWeatherCloudShadowSettings
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxBool Enable { get; set; }
        public FoxPath Texture { get; set; }
        public FoxFloat TextureMappingRange { get; set; }
        public FoxFloat WindInfluence { get; set; }
    }
}
