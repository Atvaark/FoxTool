using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppRainFilterInterrupt
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxMatrix4> PlaneMatrices { get; set; }
        public List<FoxPath> MaskTextures { get; set; }
    }
}
