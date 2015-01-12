using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SubtitlesGenerator
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr Files { get; set; }
        public FoxFilePtr RawFiles { get; set; }
        public FoxString Key { get; set; }
        public FoxColor Color { get; set; }
        public FoxVector3 Offset { get; set; }
        public FoxVector3 Size { get; set; }
        public FoxFloat FontSpace { get; set; }
        public FoxFloat LineSpace { get; set; }
        public FoxInt32 HAlign { get; set; }
        public FoxInt32 VAlign { get; set; }
        public FoxInt32 BAlign { get; set; }
        public FoxString FontName { get; set; }
        public FoxBool AutoLineFeed { get; set; }
    }
}
