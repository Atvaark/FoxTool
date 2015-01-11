using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppHelicopterRendezvousPoint
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
        public FoxString DropRouteId { get; set; }
        public FoxString ReturnRouteId { get; set; }
        public FoxQuat AdditionalRotation { get; set; }
        public FoxUInt8 Tags { get; set; }
    }
}
