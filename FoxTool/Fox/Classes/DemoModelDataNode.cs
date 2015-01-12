using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DemoModelDataNode
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString PartNames { get; set; }
        public FoxEntityLink Target { get; set; }
    }
}
