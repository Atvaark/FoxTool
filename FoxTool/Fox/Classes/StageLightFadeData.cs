using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class StageLightFadeData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxEntityLink> LightGroup { get; set; }
        public FoxColor ColorList { get; set; }
        public FoxFloat RequirdTime { get; set; }
    }
}
