using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DestructionModelDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr ModelFile { get; set; }
        public FoxFilePtr ConnectPointFile { get; set; }
        public FoxFilePtr GameRigFile { get; set; }
        public FoxFilePtr HelpBoneFile { get; set; }
        public FoxFilePtr LipAdjustFile { get; set; }
        public FoxFilePtr FacialSettingFile { get; set; }
        public FoxString InvisibleMeshNames { get; set; }
        public FoxFloat LodFarPixelSize { get; set; }
        public FoxFloat LodNearPixelSize { get; set; }
        public FoxFloat LodPolygonSize { get; set; }
        public FoxInt32 DrawRejectionLevel { get; set; }
        public FoxInt32 RejectFarRangeShadowCast { get; set; }
        public FoxFilePtr FdesFile { get; set; }
        public FoxFilePtr DesDataSetFile { get; set; }
    }
}
