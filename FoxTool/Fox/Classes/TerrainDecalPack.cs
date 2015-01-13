using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TerrainDecalPack
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr TerrainDecalPackFile { get; set; }
        public List<FoxEntityLink> MaterialLinks { get; set; }
    }
}
