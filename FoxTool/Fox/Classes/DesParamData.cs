using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DesParamData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat Density { get; set; }
        public FoxFloat Friction { get; set; }
        public FoxFloat Restitution { get; set; }
        public FoxString MaterialName { get; set; }
        public FoxInt32 DesCondition { get; set; }
        public FoxFloat DesImpactPowerThreshold { get; set; }
        public FoxFloat PhysicalCoefficient { get; set; }
    }
}
