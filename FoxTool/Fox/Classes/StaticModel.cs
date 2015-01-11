using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class StaticModel
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
        public FoxFilePtr ModelFile { get; set; }
        public FoxFilePtr GeomFile { get; set; }
        public FoxBool IsVisibleGeom { get; set; }
        public FoxBool IsIsolated { get; set; }
        public FoxFloat LodFarSize { get; set; }
        public FoxFloat LodNearSize { get; set; }
        public FoxFloat LodPolygonSize { get; set; }
        public FoxColor Color { get; set; }
        public FoxInt32 DrawRejectionLevel { get; set; }
        public FoxInt32 DrawMode { get; set; }
        public FoxInt32 RejectFarRangeShadowCast { get; set; }
    }
}
