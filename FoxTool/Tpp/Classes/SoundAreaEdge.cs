using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
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
