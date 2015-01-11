using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class PhxVehicleAxis
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityPtr VehicleAxisParam { get; set; }
        public FoxEntityPtr WheelConstraintParam { get; set; }
        public List<FoxEntityPtr> WheelAssociationUnitParams { get; set; }
        public FoxFloat TorqueDistributions { get; set; }
        public FoxFloat GearRatios { get; set; }
    }
}
