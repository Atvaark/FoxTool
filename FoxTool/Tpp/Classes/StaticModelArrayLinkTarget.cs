using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class StaticModelArrayLinkTarget
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle StaticModelArray { get; set; }
        public FoxUInt32 ArrayIndex { get; set; }
    }
}
