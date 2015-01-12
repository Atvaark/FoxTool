using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTrapCheckIsPushPadCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxUInt32 PadNumber { get; set; }
        public FoxString CheckButtons { get; set; }
    }
}
