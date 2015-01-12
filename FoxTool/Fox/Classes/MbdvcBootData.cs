using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class MbdvcBootData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr UigFile { get; set; }
        public FoxFilePtr RawFile { get; set; }
    }
}
