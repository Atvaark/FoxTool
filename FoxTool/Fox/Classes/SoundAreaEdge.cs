using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class SoundAreaEdge
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityPtr Parameter { get; set; }
        public FoxEntityLink PrevArea { get; set; }
        public FoxEntityLink NextArea { get; set; }
    }
}
