using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppBreakableStreetLampModel
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
        public FoxEntityLink RelatedLights { get; set; }
        public FoxFloat WeightLights { get; set; }
        public FoxQuat LightObjectLocalRotation { get; set; }
        public FoxVector3 LightObjectLocalTranslation { get; set; }
        public FoxInt32 LightObjectType { get; set; }
        public FoxFloat LightObjectRange { get; set; }
        public FoxFloat LightObjectAngle { get; set; }
        public FoxBool InitialOn { get; set; }
        public FoxBool LightOnlyNight { get; set; }
        public FoxBool DisableRealize { get; set; }
    }
}
