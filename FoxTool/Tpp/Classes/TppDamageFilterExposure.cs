using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppDamageFilterExposure
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat ExposureCompensation { get; set; }
        public FoxFloat MinExposure { get; set; }
        public FoxFloat MaxExposure { get; set; }
        public FoxFloat BeatExposureCompensation { get; set; }
        public FoxFloat MinBeatInterval { get; set; }
        public FoxFloat MaxBeatInterval { get; set; }
    }
}
