using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTrapExecDamageCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxBool OnlyOnce { get; set; }
        public FoxString OffenseName { get; set; }
    }
}
