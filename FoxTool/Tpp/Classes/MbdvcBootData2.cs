using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class MbdvcBootData2
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr MbFile { get; set; }
        public FoxInt32 MbType { get; set; }
    }
}
