using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class NavxNavBlock
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString SceneName { get; set; }
        public FoxString WorldName { get; set; }
        public FoxUInt32 TileId { get; set; }
        public FoxPath FilePath { get; set; }
        public FoxFilePtr FilePtr { get; set; }
        public FoxFilePtr RemainingFilePtr { get; set; }
        public FoxBool IsSplit { get; set; }
    }
}
