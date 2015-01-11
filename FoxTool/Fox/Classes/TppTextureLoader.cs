using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTextureLoader
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public Dictionary<string, FoxPath> Textures { get; set; }
        public FoxPath ForceLargeTextures { get; set; }
    }
}
