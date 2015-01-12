using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SoundSource
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxString EventName { get; set; }
        public FoxEntityLink Shapes { get; set; }
        public FoxFloat LodRange { get; set; }
        public FoxFloat PlayRange { get; set; }
    }
}
