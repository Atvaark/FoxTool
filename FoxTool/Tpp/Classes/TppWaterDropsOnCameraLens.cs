using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppWaterDropsOnCameraLens
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath DiffulseTexture { get; set; }
        public FoxPath NormalTexture { get; set; }
        public FoxFloat SizeMin { get; set; }
        public FoxFloat SizeMax { get; set; }
        public FoxFloat LifeMin { get; set; }
        public FoxFloat LifeMax { get; set; }
        public FoxFloat AngleAppear { get; set; }
        public FoxFloat AngleMax { get; set; }
        public FoxFloat WaitMin { get; set; }
        public FoxFloat WaitMax { get; set; }
    }
}
