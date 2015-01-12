using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppObjectBrushPluginSkeletonModel
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString ParentDataName { get; set; }
        public FoxBool Visibility { get; set; }
        public List<FoxFilePtr> ModelFile { get; set; }
        public List<FoxFilePtr> GeomFile { get; set; }
        public FoxFilePtr AnimFile { get; set; }
        public FoxFilePtr AnimWindyFile { get; set; }
        public FoxFloat MinSize { get; set; }
        public FoxFloat MaxSize { get; set; }
        public FoxBool IsGeomActivity { get; set; }
        public FoxFloat ThinkOutRate { get; set; }
        public List<FoxFloat> LodLength { get; set; }
    }
}
