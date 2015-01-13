using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class StaticModelArray
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr ModelFile { get; set; }
        public FoxFilePtr GeomFile { get; set; }
        public FoxBool IsVisibleGeom { get; set; }
        public FoxFloat LodFarSize { get; set; }
        public FoxFloat LodNearSize { get; set; }
        public FoxFloat LodPolygonSize { get; set; }
        public FoxInt32 DrawRejectionLevel { get; set; }
        public FoxInt32 DrawMode { get; set; }
        public FoxInt32 RejectFarRangeShadowCast { get; set; }
        public FoxEntityLink ParentLocator { get; set; }
        public List<FoxMatrix4> Transforms { get; set; }
        public List<FoxUInt32> Colors { get; set; }
    }
}
