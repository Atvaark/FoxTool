using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppGroupVehicleDefaultRideRouteInfo
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString VehicleRouteId { get; set; }
        public FoxBool IsPreferredMove { get; set; }
        public FoxEntityLink Vehicle { get; set; }
        public FoxEntityLink Members { get; set; }
    }
}
