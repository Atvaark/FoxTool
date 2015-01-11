using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DebugFlyCameraLocator : Locator
    {
        public FoxBool Enable { get; set; }
        public FoxFloat Speed { get; set; }
        public FoxBool ForceUpdateCurrentPosition { get; set; }
    }
}
