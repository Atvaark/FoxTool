using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
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
