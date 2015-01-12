using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoxPathNode
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxVector3 Position { get; set; }
        public FoxEntityHandle Inlinks { get; set; }
        public FoxEntityHandle Outlinks { get; set; }
        public FoxString NodeTags { get; set; }
    }
}
