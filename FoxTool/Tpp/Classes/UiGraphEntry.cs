using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class UiGraphEntry
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr Files { get; set; }
        public FoxFilePtr RawFiles { get; set; }
    }
}
