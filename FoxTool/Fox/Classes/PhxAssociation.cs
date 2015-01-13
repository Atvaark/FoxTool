using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class PhxAssociation
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink PhysicsData { get; set; }
        public Dictionary<string, FoxEntityPtr> Connections { get; set; }
        public FoxEntityPtr Param { get; set; }
    }
}
