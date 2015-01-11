using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppHandLightLensFlareRoot
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
        public FoxUInt32 MemoryAllocateSize { get; set; }
        public FoxBool DebugDraw { get; set; }
        public FoxBool NeedCollisionCheck { get; set; }
        public FoxBool EnableExposureScale { get; set; }
        public FoxString LensFlareName { get; set; }
        public List<FoxEntityLink> Shapes { get; set; }
    }
}
