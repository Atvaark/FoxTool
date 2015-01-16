using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class PhxVehicleNormalEngine
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxEntityLink> VehicleAxes { get; set; }
        public FoxFloat TorqueDistributions { get; set; }
        public FoxFloat GearRatios { get; set; }
        public FoxEntityPtr VehicleNormalEngineParam { get; set; }
    }
}
