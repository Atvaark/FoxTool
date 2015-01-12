using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppGuardTargetData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public List<FoxEntityHandle> Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxFloat Radius { get; set; }
        public List<FoxEntityLink> AimPoints { get; set; }
    }
}
