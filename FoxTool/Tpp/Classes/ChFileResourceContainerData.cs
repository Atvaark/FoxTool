using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class ChFileResourceContainerData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityPtr FileResources { get; set; }
    }
}
