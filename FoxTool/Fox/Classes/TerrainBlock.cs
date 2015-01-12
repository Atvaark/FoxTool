using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TerrainBlock
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 Id { get; set; }
        public FoxString TerrainName { get; set; }
        public FoxFilePtr FilePtr { get; set; }
        public FoxPath FilePath { get; set; }
        public FoxVector3 Pos { get; set; }
    }
}
