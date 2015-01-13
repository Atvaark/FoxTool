using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppModelMarkerFilterSettings
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat TexRepeatsNear { get; set; }
        public FoxFloat TexRepeatsFar { get; set; }
        public FoxFloat TexRepeatsMin { get; set; }
        public FoxFloat TexRepeatsMax { get; set; }
        public List<FoxVector3> Alphas { get; set; }
        public List<FoxVector3> Offsets { get; set; }
        public List<FoxVector3> Incidences { get; set; }
    }
}
