using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SimClothSettingData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 Iteration { get; set; }
        public FoxFloat Mass { get; set; }
        public FoxFloat VelocityDamp { get; set; }
        public FoxFloat AirResistance { get; set; }
        public FoxFloat GravityRate { get; set; }
        public FoxFloat RestoreRate { get; set; }
        public FoxFloat InertialRate { get; set; }
        public FoxFloat InertialMax { get; set; }
        public FoxBool NoHitSkinMesh { get; set; }
    }
}
