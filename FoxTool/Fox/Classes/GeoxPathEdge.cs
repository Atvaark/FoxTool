using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoxPathEdge
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxEntityHandle PrevNode { get; set; }
        public FoxEntityHandle NextNode { get; set; }
        public FoxString EdgeTags { get; set; }
    }
}
