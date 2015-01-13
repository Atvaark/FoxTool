using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppTrapConditionChangeActiveLightArea
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
        public FoxEntityPtr CheckCallbackDataElements { get; set; }
        public FoxEntityLink LightAreaHandle { get; set; }
    }
}
