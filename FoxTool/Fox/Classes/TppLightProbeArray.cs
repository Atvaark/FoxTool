using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppLightProbeArray
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public List<FoxInt32> DrawRejectionLevels { get; set; }
        public FoxEntityLink RelatedLights { get; set; }
        public List<FoxEntityLink> ShDatas { get; set; }
        public FoxFilePtr LightArrayFile { get; set; }
    }
}