using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class GeomDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr GeomFile { get; set; }
        public FoxString SkeletonName { get; set; }
        public FoxVector3 OffsetScale { get; set; }
        public FoxQuat OffsetRotQuat { get; set; }
        public FoxVector3 OffsetTranslation { get; set; }
    }
}
