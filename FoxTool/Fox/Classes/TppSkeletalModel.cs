using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppSkeletalModel
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
        public FoxFilePtr PartsFile { get; set; }
        public FoxFilePtr AnimFilePtr { get; set; }
        public FoxFilePtr AnimWindyFilePtr { get; set; }
        public FoxFilePtr LodModelFile { get; set; }
        public FoxFilePtr LodGeomFile { get; set; }
    }
}
