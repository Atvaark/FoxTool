using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GrPluginSettings
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 MotionBlurConvolutionLevel { get; set; }
        public FoxFloat ExposureCompensation { get; set; }
        public FoxFloat MinExposure { get; set; }
        public FoxFloat MaxExposure { get; set; }
        public FoxFloat KeyValue { get; set; }
        public FoxFloat BloomWhiteOffset { get; set; }
        public FoxFloat BloomColorCapacity { get; set; }
        public FoxFloat BloomSize { get; set; }
        public FoxFloat TonemapSpeed { get; set; }
        public FoxUInt8 CaptureBounceCount { get; set; }
        public FoxUInt32 MinDecalArea { get; set; }
        public FoxUInt32 Flags { get; set; }
    }
}
