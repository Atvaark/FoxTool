using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppPhaseControlParameter
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat Range { get; set; }
        public FoxFloat Sneak1Range { get; set; }
        public FoxFloat Sneak2Range { get; set; }
        public FoxFloat Sneak3Range { get; set; }
        public FoxFloat MarginLastNearChara { get; set; }
    }
}
