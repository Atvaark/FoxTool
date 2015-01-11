using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SimInertialControl
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString Bones { get; set; }
        public FoxEntityPtr ControlParam { get; set; }
    }
}
