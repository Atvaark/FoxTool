using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class SimAssociationUnit
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxEntityLink Body { get; set; }
        public FoxEntityLink Constraint { get; set; }
        public FoxVector3 BodyOffsetPos { get; set; }
        public FoxVector3 ConstraintOffsetPos { get; set; }
        public FoxQuat OffsetRot { get; set; }
        public FoxEntityPtr Param { get; set; }
    }
}
