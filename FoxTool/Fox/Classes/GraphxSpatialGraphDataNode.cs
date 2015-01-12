using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GraphxSpatialGraphDataNode
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxVector3 Position { get; set; }
        public FoxEntityHandle Inlinks { get; set; }
        public List<FoxEntityHandle> Outlinks { get; set; }
    }
}
