using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class SoundAreaMember
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Shapes { get; set; }
        public FoxUInt32 Priority { get; set; }
        public FoxEntityPtr Parameter { get; set; }
    }
}
