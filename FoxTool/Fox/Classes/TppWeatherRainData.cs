using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppWeatherRainData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink RainFilter { get; set; }
        public FoxEntityLink FloorRainSplash { get; set; }
        public FoxFilePtr VfxFileFallRain { get; set; }
        public FoxFilePtr VfxFileFallRainSlow { get; set; }
        public FoxFilePtr VfxFileCameraFog { get; set; }
    }
}
