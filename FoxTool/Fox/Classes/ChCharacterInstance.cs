using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ChCharacterInstance
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityPtr Factory { get; set; }
        public FoxEntityPtr Params { get; set; }
        public FoxUInt32 Size { get; set; }
    }
}
