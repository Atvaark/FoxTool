using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoModuleCondition
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxString TrapCategory { get; set; }
        public FoxUInt32 TrapPriority { get; set; }
        public FoxBool Enable { get; set; }
        public FoxBool IsOnce { get; set; }
        public FoxBool IsAndCheck { get; set; }
        public FoxString CheckFuncNames { get; set; }
        public FoxString ExecFuncNames { get; set; }
        public FoxEntityPtr CheckCallbackDataElements { get; set; }
        public FoxEntityPtr ExecCallbackDataElements { get; set; }
    }
}
