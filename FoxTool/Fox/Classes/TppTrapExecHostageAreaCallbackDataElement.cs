using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTrapExecHostageAreaCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxString HostageCharacterId { get; set; }
        public FoxString CommandPostCharacterId { get; set; }
    }
}
