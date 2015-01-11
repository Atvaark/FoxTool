using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class Data : Entity
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
    }
}
